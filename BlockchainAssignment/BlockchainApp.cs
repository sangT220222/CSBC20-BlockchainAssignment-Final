using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        // Global blockchain object
        private Blockchain blockchain;

        public static bool threadCheck;

        public static bool diffCheck;


        // Default App Constructor
        public BlockchainApp()
        {
            // Initialise UI Components
            InitializeComponent();
            // Create a new blockchain 
            blockchain = new Blockchain();
            // Update UI with an initalisation message
            UpdateText("New blockchain initialised!");
        }

        public static bool getThreadingOption()
        {
            return threadCheck;
        }

        public static bool getDiff()
        {
            return diffCheck;
        }

        /* PRINTING */
        // Helper method to update the UI with a provided message
        private void UpdateText(String text)
        {
            output.Text = text;
        }

        // Print entire blockchain to UI
        private void ReadAll_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.ToString());
        }

        // Print Block N (based on user input)
        private void PrintBlock_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(blockNo.Text, out int index))
                UpdateText(blockchain.GetBlockAsString(index));
            else
                UpdateText("Invalid Block No.");
        }

        // Print pending transactions from the transaction pool to the UI
        private void PrintPendingTransactions_Click(object sender, EventArgs e)
        {
            if (defaultB.Checked == true)
            {
                blockchain.transactionPool.Sort((y, x) => x.timestamp.CompareTo(y.timestamp)); //if default is checked and transaction pool is not empty
                UpdateText(String.Join("\n", blockchain.transactionPool)); //display default youngest to oldest
            }
            else if (altruisticB.Checked == true)
            {
                blockchain.transactionPool.Sort((x, y) => x.timestamp.CompareTo(y.timestamp)); //sort by oldest blocks 
                UpdateText(String.Join("\n", blockchain.transactionPool));
            }
            else if (greedyB.Checked == true)
            {
                blockchain.transactionPool.Sort((y, x) => x.fee.CompareTo(y.fee)); //sort fees high to lowest
                UpdateText(String.Join("\n", blockchain.transactionPool));
            }
            else if (unpredictableB.Checked == true)
            {
                Random rnd = new Random();
                int count = blockchain.transactionPool.Count;
                
                while (count > 1)
                {
                    count--;
                    int randomNo = rnd.Next(count + 1); //randomising
                    Transaction value = blockchain.transactionPool[randomNo];
                    blockchain.transactionPool[randomNo] = blockchain.transactionPool[count];
                    blockchain.transactionPool[count] = value;
                }
                UpdateText(String.Join("\n", blockchain.transactionPool));
            }
            else if (addressB.Checked == true && blockchain.transactionPool.Count != 0) //if address is checked and transaction pool is not empty
            {
                List<Transaction> sendAddress = new List<Transaction>();
                foreach (Transaction transaction in blockchain.transactionPool) //for every transaction in transactio pool
                {
                   
                    String address = addressText.Text; //grab the address inputted in text box

                    if (address.Equals(transaction.senderAddress)) //if equal to any addresses of transactions
                    {
                        sendAddress.Add(transaction); //add to temp list
                    }
                }
                UpdateText(String.Join("\n", sendAddress));
            }
        }

        /* WALLETS */
        // Generate a new Wallet and fill the public and private key fields of the UI
        private void GenerateWallet_Click(object sender, EventArgs e)
        {
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out string privKey);

            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;
        }

        // Validate the keys loaded in the UI by comparing their mathematical relationship
        private void ValidateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
                UpdateText("Keys are valid");
            else
                UpdateText("Keys are invalid");
        }

        // Check the balance of current user
        private void CheckBalance_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.GetBalance(publicKey.Text).ToString() + " Assignment Coin");
        }


        /* TRANSACTION MANAGEMENT */
        // Create a new pending transaction and add it to the transaction pool
        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(publicKey.Text, reciever.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            /* TODO: Validate transaction */
            blockchain.transactionPool.Add(transaction);
            UpdateText(transaction.ToString());
        }

        /* BLOCK MANAGEMENT */
        // Conduct Proof-of-work in order to mine transactions from the pool and submit a new block to the Blockchain
        private void NewBlock_Click(object sender, EventArgs e)
        {
            // Retrieve pending transactions to be added to the newly generated Block
            List<Transaction> transactions = blockchain.GetPendingTransactions();

            // Create and append the new block - requires a reference to the previous block, a set of transactions and the miners public address (For the reward to be issued)
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKey.Text);
            blockchain.blocks.Add(newBlock);

            UpdateText(blockchain.ToString());
        }


        /* BLOCKCHAIN VALIDATION */
        // Validate the integrity of the state of the Blockchain
        private void Validate_Click(object sender, EventArgs e)
        {
            // CASE: Genesis Block - Check only hash as no transactions are currently present
            if(blockchain.blocks.Count == 1)
            {
                if (!Blockchain.ValidateHash(blockchain.blocks[0])) // Recompute Hash to check validity
                    UpdateText("Blockchain is invalid");
                else
                    UpdateText("Blockchain is valid");
                return;
            }

            for (int i=1; i<blockchain.blocks.Count-1; i++)
            {
                if(
                    blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash || // Check hash "chain"
                    !Blockchain.ValidateHash(blockchain.blocks[i]) ||  // Check each blocks hash
                    !Blockchain.ValidateMerkleRoot(blockchain.blocks[i]) // Check transaction integrity using Merkle Root
                )
                {
                    UpdateText("Blockchain is invalid");
                    return;
                }
            }
            UpdateText("Blockchain is valid");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                diffCheck = true;
            }
            else
            {
                diffCheck = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                threadCheck = true;
            }
            else
            {
                threadCheck = false;
            }
        }
    }
}
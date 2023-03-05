using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace BlockchainAssignment
{
    class Block
    {
        public int blockDiff; 
        public long timeTaken;

        /* Block Variables */
        private DateTime timestamp; // Time of creation

        private int index, // Position of the block in the sequence of blocks
            difficulty = 4; // An arbitrary number of 0's to proceed a hash value

        public String prevHash, // A reference pointer to the previous block
            hash, // The current blocks "identity"
            merkleRoot,  // The merkle root of all transactions in the block
            minerAddress; // Public Key (Wallet Address) of the Miner

        public List<Transaction> transactionList; // List of transactions in this block
        
        // Proof-of-work
        public long nonce; // Number used once for Proof-of-Work and mining
        private long evenNonce = 0;
        private long oddNonce = 1;

        private string evenHash = "", oddHash = "";

        private bool threadOneFinished = false, threadTwoFinished = false;

        // Rewards
        public double reward; // Simple fixed reward established by "Coinbase"

        /* Genesis block constructor */
        public Block()
        {
            timestamp = DateTime.Now;
            index = 0;
            transactionList = new List<Transaction>();
            hash = Mine();
            blockDiff = Blockchain.difficulty;
        }

        /* New Block constructor */
        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            blockDiff = Blockchain.difficulty;

            timestamp = DateTime.Now;

            index = lastBlock.index + 1;
            prevHash = lastBlock.hash;

            this.minerAddress = minerAddress; // The wallet to be credited the reward for the mining effort
            reward = 1.0; // Assign a simple fixed value reward
            transactions.Add(createRewardTransaction(transactions)); // Create and append the reward transaction
            transactionList = new List<Transaction>(transactions); // Assign provided transactions to the block

            merkleRoot = MerkleRoot(transactionList); // Calculate the merkle root of the blocks transactions

            /*
            if (BlockchainApp.getThreadingOption() == false)
            {
             
                hash = Mine();
            }
            if (BlockchainApp.getThreadingOption() == true)
            {

                hash = hashMultiThread();
            }
            */


            if (BlockchainApp.getThreadingOption() == false)
            {
                if ((BlockchainApp.getDiff() == true) && (Blockchain.times.Count % 4 == 0))
                {
                    changeDiff();
                }

                hash = Mine();
            }
            if (BlockchainApp.getThreadingOption() == true)
            {
                if ((BlockchainApp.getDiff() == true) && (Blockchain.times.Count % 4 == 0))
                {
                    changeDiff();
                }

                hash = hashMultiThread();
            }



             // Conduct PoW to create a hash which meets the given difficulty requirement
   
        } 

        public void changeDiff()
        {
            double mean = Blockchain.times.Average(); 
            long firstTime = Blockchain.times.First(); //first time recorded in times

            long lowBound = (long)(firstTime * 0.95); //lowerbound
            long uppperBound = (long)(firstTime * 1.05); //higherbound
            if (mean < lowBound)
            { 
                Blockchain.difficulty += 1; //increases difficulty if too easy
                blockDiff += 1;

                Console.WriteLine("Average Time: " + mean);
                Console.WriteLine("First Element: " + firstTime);
                Console.WriteLine("Too Easy so increasing difficulty");
                Console.WriteLine("New Difficulty: " + blockDiff);
                Blockchain.times.Clear(); //clear the list as new difficulty is present
            }
            if ((mean > uppperBound) && (Blockchain.difficulty != 1)) 
            { 
                Blockchain.difficulty -= 1;  //decreases difficulty if too hard
                blockDiff -= 1;

                Console.WriteLine("Average Time: " + mean);
                Console.WriteLine("First Element: " + firstTime);
                Console.WriteLine("Too Hard so decreasing difficulty");
                Console.WriteLine("New Difficulty: " + blockDiff);
                Blockchain.times.Clear(); 
            }
        }

        /* Hashes the entire Block object */
        public String CreateHash(long nonce)
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();

            /* Concatenate all of the blocks properties including nonce as to generate a new hash on each call */
            String input = timestamp.ToString() + index + prevHash + nonce + merkleRoot;

            /* Apply the hash function to the block as represented by the string "input" */
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            /* Reformat to a string */
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            
            return hash;
        }

        // Create a Hash which satisfies the difficulty level required for PoW
        public String Mine()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string hash = "";
            string diffString = new string('0', Blockchain.difficulty);
            while (hash.StartsWith(diffString) == false)
            {
                hash = this.CreateHash(nonce);
                this.nonce++;
            }
            this.nonce--;

            sw.Stop();
            Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
            //Console.WriteLine("Difficulty: " + Blockchain.difficulty);

            timeTaken = sw.ElapsedMilliseconds;
            Blockchain.times.Add(timeTaken);

            return hash; // Return the hash meeting the difficulty requirement
        }

        // Merkle Root Algorithm - Encodes transactions within a block into a single hash
        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList(); // Get a list of transaction hashes for "combining"
            
            // Handle Blocks with...
            if (hashes.Count == 0) // No transactions
            {
                return String.Empty;
            }
            if (hashes.Count == 1) // One transaction - hash with "self"
            {
                return HashCode.HashTools.combineHash(hashes[0], hashes[0]);
            }
            while (hashes.Count != 1) // Multiple transactions - Repeat until tree has been traversed
            {
                List<String> merkleLeaves = new List<String>(); // Keep track of current "level" of the tree

                for (int i=0; i<hashes.Count; i+=2) // Step over neighbouring pair combining each
                {
                    if (i == hashes.Count - 1)
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i])); // Handle an odd number of leaves
                    }
                    else
                    {
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1])); // Hash neighbours leaves
                    }
                }
                hashes = merkleLeaves; // Update the working "layer"
            }
            return hashes[0]; // Return the root node
        }

        // Create reward for incentivising the mining of block
        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            double fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee); // Sum all transaction fees
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, ""); // Issue reward as a transaction in the new block
        }

        public string hashMultiThread()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string re = new string('0', Blockchain.difficulty);
            Thread th1 = new Thread(mineEven); //Initialisation of threads
            Thread th2 = new Thread(mineOdd); //Initialisation of threads

            th1.Start(); //start and join threads
            th2.Start();
            th1.Join();
            th2.Join();


            while (th1.IsAlive == true || th2.IsAlive == true) { Thread.Sleep(1); } //whilst threads are alive

            if (evenHash.StartsWith(re) == true) //if the solutio is found with even nonce
            {
                nonce = evenNonce;
                sw.Stop();
                Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
                //Console.WriteLine("Difficulty: " + Blockchain.difficulty);
                timeTaken = sw.ElapsedMilliseconds;
                Blockchain.times.Add(timeTaken); //adding time taken to the list 
                return evenHash;
            }

            else
            {
                nonce = oddNonce; //if the solutio is found with odd nonce
                Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
                //Console.WriteLine("Difficulty: " + Blockchain.difficulty);
                sw.Stop();
                timeTaken = sw.ElapsedMilliseconds;
                Blockchain.times.Add(timeTaken);
                return oddHash; 


            }

        }

        
        public void mineEven()
        {
            Boolean check = false;
            String temp_hash;
            String diffString = new string('0', Blockchain.difficulty);

            while (check == false)
            {
                temp_hash = CreateHash(evenNonce);
                if (temp_hash.StartsWith(diffString) == true) //if even hash found solution
                {
                    check = true;
                    evenHash = temp_hash; //soring the hash

                    threadOneFinished= true;

                    return;
                }
                else if (oddHash.StartsWith(diffString) == true) //if odd hash found solution
                {
                    Thread.Sleep(1);
                    return;
                }
                else
                {
                    check = false;
                    evenNonce += 2;
                }
            }
            return;

        }
        public void mineOdd()
        {
            Boolean check = false;
            String temp_hash;
            String diffString = new string('0', Blockchain.difficulty);

            while (check == false)
            {
                temp_hash = CreateHash(oddNonce);
                if (temp_hash.StartsWith(diffString) == true)
                {
                    check = true;
                    oddHash = temp_hash;

                    threadTwoFinished = true;

                    return;
                }
                else if (evenHash.StartsWith(diffString) == true)
                {
                    Thread.Sleep(1);
                    return;
                }
                else
                {
                    check = false;
                    oddNonce += 2;
                }
            }
            return;

        }

    




        /* Concatenate all properties to output to the UI */
        public override string ToString()
        {
            return "[BLOCK START]"
                + "\nIndex: " + index
                + "\tTimestamp: " + timestamp
                + "\nPrevious Hash: " + prevHash
                + "\n-- PoW --"
                + "\nDifficulty Level: " + blockDiff
                + "\nNonce: " + nonce
                + "\nHash: " + hash
                + "\n-- Rewards --"
                + "\nReward: " + reward
                + "\nMiners Address: " + minerAddress
                + "\n-- " + transactionList.Count + " Transactions --"
                +"\nMerkle Root: " + merkleRoot
                + "\n" + String.Join("\n", transactionList)
                + "\n[BLOCK END]";
        }
    }
}

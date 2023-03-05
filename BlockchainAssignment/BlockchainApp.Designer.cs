namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.blockNo = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.validateKeys = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.reciever = new System.Windows.Forms.TextBox();
            this.recieverKeyLabel = new System.Windows.Forms.Label();
            this.newBlock = new System.Windows.Forms.Button();
            this.printBlockchain = new System.Windows.Forms.Button();
            this.readPendingTransactions = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.currentWalletLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.blocksLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.greedyB = new System.Windows.Forms.RadioButton();
            this.altruisticB = new System.Windows.Forms.RadioButton();
            this.addressB = new System.Windows.Forms.RadioButton();
            this.defaultB = new System.Windows.Forms.RadioButton();
            this.unpredictableB = new System.Windows.Forms.RadioButton();
            this.addressText = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(21, -5);
            this.output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(688, 545);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(716, 98);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(99, 38);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Block #";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.PrintBlock_Click);
            // 
            // blockNo
            // 
            this.blockNo.Location = new System.Drawing.Point(820, 105);
            this.blockNo.Name = "blockNo";
            this.blockNo.Size = new System.Drawing.Size(34, 26);
            this.blockNo.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(38, 568);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(118, 85);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate New Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.GenerateWallet_Click);
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(170, 586);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(81, 20);
            this.publicKeyLabel.TabIndex = 4;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(164, 618);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(87, 20);
            this.privateKeyLabel.TabIndex = 5;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(254, 582);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(282, 26);
            this.publicKey.TabIndex = 6;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(256, 612);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(278, 26);
            this.privateKey.TabIndex = 7;
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(550, 578);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(130, 34);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.ValidateKeys_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(714, 269);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(292, 40);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(956, 206);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(52, 26);
            this.fee.TabIndex = 13;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(831, 206);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(52, 26);
            this.amount.TabIndex = 12;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(914, 209);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(37, 20);
            this.feeLabel.TabIndex = 11;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(760, 209);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(65, 20);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount";
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(831, 237);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(176, 26);
            this.reciever.TabIndex = 15;
            // 
            // recieverKeyLabel
            // 
            this.recieverKeyLabel.AutoSize = true;
            this.recieverKeyLabel.Location = new System.Drawing.Point(724, 240);
            this.recieverKeyLabel.Name = "recieverKeyLabel";
            this.recieverKeyLabel.Size = new System.Drawing.Size(101, 20);
            this.recieverKeyLabel.TabIndex = 14;
            this.recieverKeyLabel.Text = "Reciever Key";
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(717, 51);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(294, 40);
            this.newBlock.TabIndex = 16;
            this.newBlock.Text = "Generate New Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.NewBlock_Click);
            // 
            // printBlockchain
            // 
            this.printBlockchain.Location = new System.Drawing.Point(862, 98);
            this.printBlockchain.Name = "printBlockchain";
            this.printBlockchain.Size = new System.Drawing.Size(148, 38);
            this.printBlockchain.TabIndex = 17;
            this.printBlockchain.Text = "Entire Chain";
            this.printBlockchain.UseVisualStyleBackColor = true;
            this.printBlockchain.Click += new System.EventHandler(this.ReadAll_Click);
            // 
            // readPendingTransactions
            // 
            this.readPendingTransactions.Location = new System.Drawing.Point(716, 431);
            this.readPendingTransactions.Name = "readPendingTransactions";
            this.readPendingTransactions.Size = new System.Drawing.Size(294, 38);
            this.readPendingTransactions.TabIndex = 18;
            this.readPendingTransactions.Text = "Read Pending Transactions";
            this.readPendingTransactions.UseVisualStyleBackColor = true;
            this.readPendingTransactions.Click += new System.EventHandler(this.PrintPendingTransactions_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(712, 582);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(294, 71);
            this.validate.TabIndex = 19;
            this.validate.Text = "Full Blockchain Validation";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(550, 615);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(130, 37);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // currentWalletLabel
            // 
            this.currentWalletLabel.AutoSize = true;
            this.currentWalletLabel.Location = new System.Drawing.Point(34, 545);
            this.currentWalletLabel.Name = "currentWalletLabel";
            this.currentWalletLabel.Size = new System.Drawing.Size(110, 20);
            this.currentWalletLabel.TabIndex = 22;
            this.currentWalletLabel.Text = "Current Wallet";
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(712, 169);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(100, 20);
            this.transactionLabel.TabIndex = 23;
            this.transactionLabel.Text = "Transactions";
            // 
            // blocksLabel
            // 
            this.blocksLabel.AutoSize = true;
            this.blocksLabel.Location = new System.Drawing.Point(716, 18);
            this.blocksLabel.Name = "blocksLabel";
            this.blocksLabel.Size = new System.Drawing.Size(56, 20);
            this.blocksLabel.TabIndex = 24;
            this.blocksLabel.Text = "Blocks";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Location = new System.Drawing.Point(716, 542);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(79, 20);
            this.validationLabel.TabIndex = 25;
            this.validationLabel.Text = "Validation";
            // 
            // greedyB
            // 
            this.greedyB.AutoSize = true;
            this.greedyB.Location = new System.Drawing.Point(720, 362);
            this.greedyB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greedyB.Name = "greedyB";
            this.greedyB.Size = new System.Drawing.Size(86, 24);
            this.greedyB.TabIndex = 26;
            this.greedyB.TabStop = true;
            this.greedyB.Text = "Greedy";
            this.greedyB.UseVisualStyleBackColor = true;
            // 
            // altruisticB
            // 
            this.altruisticB.AutoSize = true;
            this.altruisticB.Location = new System.Drawing.Point(718, 397);
            this.altruisticB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altruisticB.Name = "altruisticB";
            this.altruisticB.Size = new System.Drawing.Size(94, 24);
            this.altruisticB.TabIndex = 27;
            this.altruisticB.TabStop = true;
            this.altruisticB.Text = "Altruistic";
            this.altruisticB.UseVisualStyleBackColor = true;
            // 
            // addressB
            // 
            this.addressB.AutoSize = true;
            this.addressB.Location = new System.Drawing.Point(882, 362);
            this.addressB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressB.Name = "addressB";
            this.addressB.Size = new System.Drawing.Size(143, 24);
            this.addressB.TabIndex = 29;
            this.addressB.TabStop = true;
            this.addressB.Text = "Address Based";
            this.addressB.UseVisualStyleBackColor = true;
            // 
            // defaultB
            // 
            this.defaultB.AutoSize = true;
            this.defaultB.Location = new System.Drawing.Point(718, 326);
            this.defaultB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.defaultB.Name = "defaultB";
            this.defaultB.Size = new System.Drawing.Size(86, 24);
            this.defaultB.TabIndex = 30;
            this.defaultB.TabStop = true;
            this.defaultB.Text = "Default";
            this.defaultB.UseVisualStyleBackColor = true;
            // 
            // unpredictableB
            // 
            this.unpredictableB.AutoSize = true;
            this.unpredictableB.Location = new System.Drawing.Point(882, 326);
            this.unpredictableB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unpredictableB.Name = "unpredictableB";
            this.unpredictableB.Size = new System.Drawing.Size(133, 24);
            this.unpredictableB.TabIndex = 31;
            this.unpredictableB.TabStop = true;
            this.unpredictableB.Text = "Unpredictable";
            this.unpredictableB.UseVisualStyleBackColor = true;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(882, 392);
            this.addressText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(134, 26);
            this.addressText.TabIndex = 32;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(782, 18);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 24);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Adaptive Difficulty";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(782, 144);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 24);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "Apply Multi-threading";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 695);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.unpredictableB);
            this.Controls.Add(this.defaultB);
            this.Controls.Add(this.addressB);
            this.Controls.Add(this.altruisticB);
            this.Controls.Add(this.greedyB);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.blocksLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.currentWalletLabel);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readPendingTransactions);
            this.Controls.Add(this.printBlockchain);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.recieverKeyLabel);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.blockNo);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.output);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox blockNo;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Label recieverKeyLabel;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Button printBlockchain;
        private System.Windows.Forms.Button readPendingTransactions;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Label currentWalletLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label blocksLabel;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.RadioButton greedyB;
        private System.Windows.Forms.RadioButton altruisticB;
        private System.Windows.Forms.RadioButton addressB;
        private System.Windows.Forms.RadioButton defaultB;
        private System.Windows.Forms.RadioButton unpredictableB;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}


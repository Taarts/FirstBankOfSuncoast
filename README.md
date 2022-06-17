# FirstBankOfSuncoast

P:roblem:
A console to manage two accounts:

1. create a menu to field interactions from the user
2. checking
3. savings

User will be able to:

- retrieve balances from both
- retrieve transactions from both

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using CsvHelper;
create a CSV file to store the transactions and produce the sum of the transactions that take place.

App:
Store history of transactions in a single "List<Transaction>".

- design a Transaction class to support both checking and savings as well as deposits and withdrawals.
  - deposits (see AddEmployee - SHR)
- load past transactions from file. (see FindOneEmployee - SHR)
- cannot withdraw more than available funds in any account (FirstOrDefault)
- the input from the user should always be a positive integer (something like "ToUpper()"? or "please reenter your request")
- create a menu for user interaction
  - deposit to savings (List<depositSavings>)
  - deposit to checking - ditto
  - withdraw from savings(List<withdrawalSavings>)
  - withdraw from checking - ditto
  - see balance Ch & S
    Write all transactions to file

E:xamples:
Checking:
starting Balance:
100
Deposit:
20
30
10
-5
1000
-1000

Withdraw:
10
50
100
-30
-10
60
500

Savings:
200
Deposit:
20
30
10
-5
1000
-1000

Withdraw:
10
50
100
-30
-10
60
500

D:ata Structures
positive integers
lists - deposits/withdrawals
Methods: to do the math for each type of transaction

- deposit: if (deposit){ var value = balance; new value = value + deposit; value++;}(maybe this?)
  class Transaction
  Menu selection method - switch (?)

A:lgoithm
create a menu to field interactions from the user

Welcome msg
Which account?
Ch? S?
Deposit?
Withdrawal?
Check balance?
ReadLine for each response

Store history of transactions in a single "List<Transaction>".

Transaction class:
Methods

- to load Transactions (returns nothing, just populates the list)
- Write transactions to file (SaveTransactions)
- read and get all the transactions, and provides a balance for the account
- provides balance per account
-

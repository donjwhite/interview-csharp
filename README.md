# Neovest coding interview problem

This project contains a C# skeleton solution for the problem described below.

Candidates are asked to implement a solution to the problem and add additional unit tests.

## Contents

* Interview - C# stubbs for the solution
* InterviewTests - MSTest unit tests

## Problem(s)

### Average price per share

Given a list of trades, compute the average price per share.  Each trade has a price and a number of shares.

The average price per share is the weighted average of the prices in each trade. The number of shares is multiplied
by the price for each trade and then added together for all the trades. The sum is then divided by the total number
of shares across all trades.

### Example

Trade 1: 20 shares at $5.00 / share

Trade 2: 40 shares at $6.00 / share

Average Price per share = (20 * 5.0 + 40 * 6.0)  / 60 = 5.67
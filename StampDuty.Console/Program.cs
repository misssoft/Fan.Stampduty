﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampDuty.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Freehold or LeaseHold");
                System.Console.WriteLine("1. Freehold");
                System.Console.WriteLine("2. Leasehold");
                var isFreehold = System.Console.ReadLine();

                if (isFreehold == "1")
                {
                    System.Console.WriteLine("Residential or Non-residential");
                    System.Console.WriteLine("1. Residential");
                    System.Console.WriteLine("2. Non-residential");
                    var isResidential = System.Console.ReadLine();

                    if (isFreehold == "1")
                    {
                        System.Console.WriteLine("Transaction Date");
                        System.Console.WriteLine("1. After 01/04/2016");
                        System.Console.WriteLine("2. Before 01/04/2016");
                        var transactionDate = System.Console.ReadLine();

                        if (transactionDate == "1")
                        {
                            System.Console.WriteLine("Individual or Joined");
                            System.Console.WriteLine("1. Individual");
                            System.Console.WriteLine("2. Joined");
                            var isIndividual = System.Console.ReadLine();

                            if (isIndividual == "1")
                            {
                                System.Console.WriteLine("Second Home");
                                System.Console.WriteLine("1. Yes");
                                System.Console.WriteLine("2. No");
                                var isSecond = System.Console.ReadLine();

                                if (isSecond == "1")
                                {
                                    System.Console.WriteLine("Replacing main property");
                                    System.Console.WriteLine("1. Yes");
                                    System.Console.WriteLine("2. No");
                                    var isReplacing = System.Console.ReadLine();

                                    if (isReplacing == "1")
                                    {
                                        System.Console.WriteLine("Property Price:");
                                        var price = System.Console.ReadLine();

                                        System.Console.WriteLine($"Price: {price}");
                                        System.Console.WriteLine($"Replacing main property: {isReplacing}");
                                        System.Console.WriteLine($"Second Home: {isSecond}");
                                        System.Console.WriteLine($"Individual: {isIndividual}");
                                        System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                        System.Console.WriteLine($"Residential: {isResidential}");
                                        System.Console.WriteLine($"Freehold: {isFreehold}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Property Price:");
                                        var price = System.Console.ReadLine();
                                        System.Console.WriteLine($"Price: {price}");
                                        System.Console.WriteLine($"Replacing main property: {isReplacing}");
                                        System.Console.WriteLine($"Second Home: {isSecond}");
                                        System.Console.WriteLine($"Individual: {isIndividual}");
                                        System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                        System.Console.WriteLine($"Residential: {isResidential}");
                                        System.Console.WriteLine($"Freehold: {isFreehold}");
                                    }
                                }
                                else
                                {
                                    System.Console.WriteLine("Property Price:");
                                    var price = System.Console.ReadLine();
                                    System.Console.WriteLine($"Price: {price}");
                                    System.Console.WriteLine($"Second Home: {isSecond}");
                                    System.Console.WriteLine($"Individual: {isIndividual}");
                                    System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                    System.Console.WriteLine($"Residential: {isResidential}");
                                    System.Console.WriteLine($"Freehold: {isFreehold}");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Property Price:");
                                var price = System.Console.ReadLine();
                                System.Console.WriteLine($"Price: {price}");
                                System.Console.WriteLine($"Individual: {isIndividual}");
                                System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                System.Console.WriteLine($"Residential: {isResidential}");
                                System.Console.WriteLine($"Freehold: {isFreehold}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Property Price:");
                            var price = System.Console.ReadLine();
                            System.Console.WriteLine($"Price: {price}");
                            System.Console.WriteLine($"TransactionDate: {transactionDate}");
                            System.Console.WriteLine($"Residential: {isResidential}");
                            System.Console.WriteLine($"Freehold: {isFreehold}");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Property Price:");
                        var price = System.Console.ReadLine();
                        System.Console.WriteLine($"Price: {price}");
                        System.Console.WriteLine($"Residential: {isResidential}");
                        System.Console.WriteLine($"Freehold: {isFreehold}");
                    }
                }
                else
                {
                    System.Console.WriteLine("Residential or Non-residential");
                    System.Console.WriteLine("1. Residential");
                    System.Console.WriteLine("2. Non-residential");
                    var isResidential = System.Console.ReadLine();

                    if (isFreehold == "1")
                    {
                        System.Console.WriteLine("Transaction Date");
                        System.Console.WriteLine("1. After 01/04/2016");
                        System.Console.WriteLine("2. Before 01/04/2016");
                        var transactionDate = System.Console.ReadLine();

                        if (transactionDate == "1")
                        {
                            System.Console.WriteLine("Individual or Joined");
                            System.Console.WriteLine("1. Individual");
                            System.Console.WriteLine("2. Joined");
                            var isIndividual = System.Console.ReadLine();

                            if (isIndividual == "1")
                            {
                                System.Console.WriteLine("Second Home");
                                System.Console.WriteLine("1. Yes");
                                System.Console.WriteLine("2. No");
                                var isSecond = System.Console.ReadLine();

                                if (isSecond == "1")
                                {
                                    System.Console.WriteLine("Replacing main property");
                                    System.Console.WriteLine("1. Yes");
                                    System.Console.WriteLine("2. No");
                                    var isReplacing = System.Console.ReadLine();

                                    if (isReplacing == "1")
                                    {
                                        System.Console.WriteLine("Property Price:");
                                        var price = System.Console.ReadLine();

                                        System.Console.WriteLine($"Price: {price}");
                                        System.Console.WriteLine($"Replacing main property: {isReplacing}");
                                        System.Console.WriteLine($"Second Home: {isSecond}");
                                        System.Console.WriteLine($"Individual: {isIndividual}");
                                        System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                        System.Console.WriteLine($"Residential: {isResidential}");
                                        System.Console.WriteLine($"Freehold: {isFreehold}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Property Price:");
                                        var price = System.Console.ReadLine();
                                        System.Console.WriteLine($"Price: {price}");
                                        System.Console.WriteLine($"Replacing main property: {isReplacing}");
                                        System.Console.WriteLine($"Second Home: {isSecond}");
                                        System.Console.WriteLine($"Individual: {isIndividual}");
                                        System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                        System.Console.WriteLine($"Residential: {isResidential}");
                                        System.Console.WriteLine($"Freehold: {isFreehold}");
                                    }
                                }
                                else
                                {
                                    System.Console.WriteLine("Property Price:");
                                    var price = System.Console.ReadLine();
                                    System.Console.WriteLine($"Price: {price}");
                                    System.Console.WriteLine($"Second Home: {isSecond}");
                                    System.Console.WriteLine($"Individual: {isIndividual}");
                                    System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                    System.Console.WriteLine($"Residential: {isResidential}");
                                    System.Console.WriteLine($"Freehold: {isFreehold}");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Property Price:");
                                var price = System.Console.ReadLine();
                                System.Console.WriteLine($"Price: {price}");
                                System.Console.WriteLine($"Individual: {isIndividual}");
                                System.Console.WriteLine($"TransactionDate: {transactionDate}");
                                System.Console.WriteLine($"Residential: {isResidential}");
                                System.Console.WriteLine($"Freehold: {isFreehold}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Property Price:");
                            var price = System.Console.ReadLine();
                            System.Console.WriteLine($"Price: {price}");
                            System.Console.WriteLine($"TransactionDate: {transactionDate}");
                            System.Console.WriteLine($"Residential: {isResidential}");
                            System.Console.WriteLine($"Freehold: {isFreehold}");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Property Price:");
                        var price = System.Console.ReadLine();
                        System.Console.WriteLine($"Price: {price}");
                        System.Console.WriteLine($"Residential: {isResidential}");
                        System.Console.WriteLine($"Freehold: {isFreehold}");
                    }

                }
                System.Console.ReadLine();
            }
        }
    }
}


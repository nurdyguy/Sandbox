using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Models;

namespace Sandbox.Controllers
{
    public class SandboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LinkedAccountsMock()
        {
            var vm = new List<LinkedAccountVM>()
            {
                new LinkedAccountVM()
                {
                    AccountName = "Main Checking",
                    BankName = "Wells Fargo Bank",
                    AccountNumber = "1152-88534",
                    Balance = 875.51,
                    VerificationStage = VerificationStage.Verified,
                    RecurringTransfers = new List<RecurringTransferVM>()
                    {
                        new RecurringTransferVM()
                        {
                            ExternalAccountName = "Main Checking",
                            InternalAccountName = "Unify Checking -- 118130",
                            Ammount = 100,
                            Frequency = TransferFrequence.Monthly,
                            IsDebit = true
                        },
                        new RecurringTransferVM()
                        {
                            ExternalAccountName = "Main Checking",
                            InternalAccountName = "Unify Savings -- 25117",
                            Ammount = 1000,
                            Frequency = TransferFrequence.Annually,
                            IsDebit = false
                        }
                    },
                    Transfers = new List<TransferVM>()
                    {
                        new TransferVM()
                        {
                            ExternalAccountName = "Main Checking",
                            InternalAccountName = "Unify Checking -- 118130",
                            TransferDate = new DateTime(2019, 6, 20),
                            Ammount = 100,
                            IsDebit = true
                        },
                        new TransferVM()
                        {
                            ExternalAccountName = "Main Checking",
                            InternalAccountName = "Unify Checking -- 118130",
                            TransferDate = new DateTime(2019, 6, 10),
                            Ammount = 50,
                            IsDebit = false
                        },
                        new TransferVM()
                        {
                            ExternalAccountName = "Main Checking",
                            InternalAccountName = "Unify Checking -- 118130",
                            TransferDate = new DateTime(2019, 5, 20),
                            Ammount = 100,
                            IsDebit = true
                        }
                        
                    }
                },
                new LinkedAccountVM()
                {
                    AccountName = "Steve's old checking",
                    BankName = "Bank of America",
                    AccountNumber = "55233681",
                    Balance = 0,
                    VerificationStage = VerificationStage.InProcess,
                    RecurringTransfers = new List<RecurringTransferVM>()
                    {
                        
                    },
                    Transfers = new List<TransferVM>()
                    {

                    }
                },
                 new LinkedAccountVM()
                {
                    AccountName = "Ellen's ING savings",
                    BankName = "ING",
                    AccountNumber = "55233681",
                    Balance = 0,
                    VerificationStage = VerificationStage.Invalid,
                    RecurringTransfers = new List<RecurringTransferVM>()
                    {

                    },
                    Transfers = new List<TransferVM>()
                    {

                    }
                }
            };

            return View(vm);
        }

       
    }
}

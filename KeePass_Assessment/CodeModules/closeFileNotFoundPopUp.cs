/*
 * Created by Ranorex
 * User: Planit-1
 * Date: 24-11-2025
 * Time: 22:54
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace KeePass_Assessment.CodeModules
{
    /// <summary>
    /// Description of closeFileNotFoundPopUp.
    /// </summary>
    [TestModule("FC1DD1C4-D479-4806-B672-9DA2C94FF569", ModuleType.UserCode, 1)]
    public class closeFileNotFoundPopUp : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public closeFileNotFoundPopUp()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
            KeePass_AssessmentRepository winPop = new KeePass_AssessmentRepository();
            if(winPop.New_DB_Confirmation_PopUp.Btn_FileNotFound_OK.Visible){
            	winPop.New_DB_Confirmation_PopUp.Btn_FileNotFound_OK.Click();
            }
        }
        }
    }


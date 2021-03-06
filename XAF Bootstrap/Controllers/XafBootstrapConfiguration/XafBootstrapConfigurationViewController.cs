#region Copyright (c) 2014-2016 DevCloud Solutions
/*
{********************************************************************************}
{                                                                                }
{   Copyright (c) 2014-2016 DevCloud Solutions                                   }
{                                                                                }
{   Licensed under the Apache License, Version 2.0 (the "License");              }
{   you may not use this file except in compliance with the License.             }
{   You may obtain a copy of the License at                                      }
{                                                                                }
{       http://www.apache.org/licenses/LICENSE-2.0                               }
{                                                                                }
{   Unless required by applicable law or agreed to in writing, software          }
{   distributed under the License is distributed on an "AS IS" BASIS,            }
{   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.     }
{   See the License for the specific language governing permissions and          }
{   limitations under the License.                                               }
{                                                                                }
{********************************************************************************}
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;

namespace XAF_Bootstrap.Controllers.XafBootstrapConfiguration
{
    
    public partial class XafBootstrapConfigurationViewController : ViewController
    {
        public XafBootstrapConfigurationViewController()
        {
            InitializeComponent();         
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            Frame.GetController<NewObjectViewController>().NewObjectAction.Active["BootstrapActive"] = false;
            Frame.GetController<DeleteObjectsViewController>().DeleteAction.Active["BootstrapActive"] = false;            
        }        
        protected override void OnDeactivated()
        {
            Frame.GetController<NewObjectViewController>().NewObjectAction.Active.RemoveItem("BootstrapActive");
            Frame.GetController<DeleteObjectsViewController>().DeleteAction.Active.RemoveItem("BootstrapActive");
            base.OnDeactivated();
        }
    }
}

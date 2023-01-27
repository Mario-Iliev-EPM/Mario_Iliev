using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace WebUITests.Utils
{
    [Binding]
    public class StepTransformations
    {
        [StepArgumentTransformation]
        public Credentials GetCredentials(Table table)=>  table.CreateInstance<Credentials>();  
            }
}

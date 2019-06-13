using CodeConverter.Tests.TestRunners;
using ICSharpCode.CodeConverter.VB;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CS2VB
{
    public class SolutionAndProjectConverter : ProjectConverterBase
    {
        public async Task ConvertSolution(string solutionPath)
        {
            await ConvertProjectsWhere<CSToVBConversion>(solutionPath,  p => true);
        }

        //public async Task ConvertSingleProject()
        //{
        //    await ConvertProjectsWhere<CSToVBConversion>(p => p.Name == "CSharpConsoleApp");
        //}
    }
}

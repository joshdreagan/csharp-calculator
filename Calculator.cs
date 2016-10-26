using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace MathLibrary
{
    public class Calculator : ICalculator
    {
        public int Add(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            return (num1 + num2);
        }

        public int Multiply(int num1, int num2)
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
            return (num1 * num2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using Teorie.controler;

namespace Test
{
    public class ControlPersoanaTest
    {
        private ControlPersoana control;

        [Fact]

        public void load()
        {
            this.control = new ControlPersoana();

            string text = this.control.toString();

            Assert.NotNull(text);
            


        }

        [Fact]

        public void sizeOfObjects()
        {

            this.control=new ControlPersoana();

            int k = this.control.sizeOfObject("administrator");

            Assert.Equal(3, k);

        }

    }
}

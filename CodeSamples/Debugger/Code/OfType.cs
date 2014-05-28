using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger.Code
{



    class OfType : ICode 
    {



        public void Start()
        {


            List<object> list = new List<object>();
            list.Add(new OfType_Class() { Id = 1 });
            list.Add(new OfType_Class() { Id = 2 });
            list.Add(new OfType_Class() { Id = 3 });


            foreach (OfType_Base r in list.OfType<OfType_Base>()) {

                Console.WriteLine(r.Id);
            }




            throw new NotImplementedException();
        }


    }



    public class OfType_Class : OfType_Base
    {

        public int Name { get; set; }

    }


    public class OfType_Base
    {


        public int Id { get; set; }

    }






}

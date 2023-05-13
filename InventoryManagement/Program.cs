using InventoryManagement;

namespace InvetoryManagement 
{
    class program
    {
        public static void Main(string[] args) 
        {
            string path = "D:\\bridgelabz\\InventoryManagement\\InventoryManagement\\jsconfig1.json";
            ReadTheData readTheData = new ReadTheData();
            InventoryDetails data =  readTheData.Read(path);
            Console.WriteLine("================== Types Of Rice  =================");
            for (int i =0;i<data.typesOfRice.Count;i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                int invetoryprice = data.typesOfRice[i].weight * data.typesOfRice[i].price;
                Console.WriteLine("The Price {0} {1}kg is {2}rs  ", data.typesOfRice[i].name, data.typesOfRice[i].weight, data.typesOfRice[i].price, invetoryprice);
            }
            Console.WriteLine("================== Types Of wheate  =================");
            for (int i = 0; i < data.typesOfWheate.Count; i++)
            {
                Console.WriteLine(data.typesOfWheate[i].name);
                Console.WriteLine(data.typesOfWheate[i].weight);
                Console.WriteLine(data.typesOfWheate[i].price);
                int invetoryprice = data.typesOfWheate[i].weight * data.typesOfWheate[i].price;

                Console.WriteLine("The Price {0} {1}kg is {2}rs  ", data.typesOfWheate[i].name, data.typesOfWheate[i].weight, data.typesOfWheate[i].price, invetoryprice);

            }
            Console.WriteLine("================== Types Of pulses  =================");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
                int invetoryprice = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;
                Console.WriteLine("The Price {0} {1}kg is {2}rs  ", data.typesOfPulses[i].name, data.typesOfPulses[i].weight, data.typesOfPulses[i].price, invetoryprice);

            }

        }
    }
}
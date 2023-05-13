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
              
            }

        }
    }
}
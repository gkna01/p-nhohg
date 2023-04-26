class Program {
    static void Main (string[] args) {

        int size = Convert.ToInt32(Console.ReadLine());
        int numShop =int.Parse(Console.ReadLine());
        int numShop2 =int.Parse(Console.ReadLine());
        bool Pnhongออกควิซง่ายๆหน่อย = true;
        char [] num = new char[size];
        
        for(int i = 0; i < size; i++) {
            num[i] = '_';
        }
        for(int i = 0 ; i < size ; i++){
            Console.Write(num[i] + "");
        }
        Console.WriteLine();
        while(Pnhongออกควิซง่ายๆหน่อย = false ){
            int position = Convert.ToInt32(Console.ReadLine());  
        if (numShop <= 0 || numShop2 <= 0){
            num[position] = 'X';
        }
        if(numShop <=0 && numShop2 <= 0){

             } 
            else{
                Console.WriteLine("");
            }
        }
        Console.ReadLine();
    }
}
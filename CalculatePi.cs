using System;

namespace test_C_ {
    class CalculatePi {
        public static void Run (int points) {
            double total_nodes = 0;
            double valid_nodes = 0;
            for(int i = 0; i < points; i++){
                var x_coord = RandomNumber();
                var y_coord = RandomNumber();
                if ((x_coord*x_coord + y_coord*y_coord) < 1){
                    valid_nodes += 1;
                }
                total_nodes += 1;
            }
            var estimatedPI = 4.00 * (valid_nodes/total_nodes);
            Console.WriteLine(estimatedPI);
        }


        public static double RandomNumber(){
            var random = new Random();
            return random.Next(0, 100) /100.0;
        }
    }
}
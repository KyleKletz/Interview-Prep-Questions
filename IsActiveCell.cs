using System;

namespace test_C_
{
        class IsActiveCell 
    {
        public static void Run () {
            var expected = new int[] { 0, 0, 0, 0, 0, 1, 1, 0 };

            var numbers = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            var days = 2;
            var actual = calculateIsValid (numbers, days);

            if (String.Join (',', expected) != String.Join (',', actual)) {
                Console.WriteLine ("Wrong!");
            } else {
                Console.WriteLine ("Correct!");
            }

            Console.WriteLine ($"actual: \t{String.Join(',',actual)}  \nexpected: \t{String.Join(',', expected)}");
        }
        
        public static int[] calculateIsValid (int[] numbers, int days) {
            var final = new int[numbers.Length];

            var current = numbers;

            for (int day = 1; day <= days; day++) {
                for (int counter = 0; counter < numbers.Length; counter++) {
                    if (counter == 0) {
                        final[counter] = isActive (current[counter + 1], 0);
                    } else if (counter == numbers.Length - 1) {
                        final[counter] = isActive (current[counter - 1], 0);
                    } else {
                        final[counter] = isActive (current[counter + 1], current[counter - 1]);
                    }
                }
                current = (int[]) final.Clone ();
            }

            return final;
        }

        public static int isActive (int num1, int num2) {
            if (num1 != num2) {
                return 1;
            }
            return 0;

        }
    }
}
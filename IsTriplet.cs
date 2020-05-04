using System;
#nullable enable

namespace test_C_ {
    class IsTriplet {

        public static void Run () {
            var input = new int[] { 3, 1, 4, 6, 5 };

            var actual = ContainsTriplet (input);

            if (actual != null) {
                Console.WriteLine ($"\n\nSuccess \nvalues {String.Join (',', actual)}");
            } else {
                Console.WriteLine ("Failed");

            }
        }

        public static int[]? ContainsTriplet (int[] arr) {
            var length = arr.Length;
            for (int first = 0; first < length; first++) {
                for (int second = first + 1; second < length; second++) {
                    for (int third = second + 1; third < length; third++) {
                        int num1 = arr[first] * arr[first];
                        int num2 = arr[second] * arr[second];
                        int num3 = arr[third] * arr[third];

                        if (num1 == (num2 + num3) || num2 == (num1 + num3) || num3 == (num1 + num2)) {
                            return new int[] { arr[first], arr[second], arr[third] };
                        }
                    }
                }
            }
            return null;
        }
    }
}
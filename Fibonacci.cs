namespace csharptest {
    public static class Fibonacci {
        public static int fibMemo(int n, int[] arr) {
            if (arr[n] > 0) {
                return arr[n];
            }
            if ((n == 0) || (n == 1)) {
                return n;
            } else {
                int res = fibMemo(n-1, arr) + fibMemo(n-2, arr);
                arr[n] = res; 
                return res;
            }
        }
        public static int fibSimple(int n) {
            if ((n == 0) || (n == 1)) {
                return n;
            } else {
                return fibSimple(n-1) + fibSimple(n-2);
            }
        }
    }
}
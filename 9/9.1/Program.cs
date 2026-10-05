int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};

try { 
    // increment
    for (int i=0 ; i<iterationer ; i++) { //the part with the exception has to be within the try
    array[i]++;
        if (i>4) { throw new Exception("Indexoutofrange");
        }
    }
}
catch (Exception) {}

// print
for (int i=0 ; i<array.Length ; i++) {
Console.WriteLine(array[i]);
}

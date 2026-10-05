int [,] Sudoku = {
    {4,3,0,5,0,0,0,0,6},
    {0,0,8,0,2,0,0,1,9},
    {0,1,7,0,0,0,4,5,0},
    {8,6,0,2,0,0,0,7,0},
    {0,7,4,8,0,0,2,6,0},
    {1,0,9,0,0,7,8,3,0},
    {2,0,0,1,7,8,0,4,3},
    {0,0,1,9,4,0,0,0,7},
    {0,0,0,6,5,0,0,0,0}
};

//Following code is simply for printing the sudoku 
int count = 0; //count for which item in the array we are at
foreach(int item in Sudoku){
    Console.Write(item + " ");
    count++;
    if (count%  9 == 0) { //for every 9 items we jump a line
        Console.WriteLine("");
    }
}

bool [] found = new bool [9];


//check collumns
for (int x = 0 ; x<8 ; x++)  { 
    for (int y = 0 ; y<8 ; y++) {
    int value = Sudoku[y,x];  //value equals the value in a cell in the sudkoku puzzle given an x and y value (representing row and collumn)
    found[value - 1]= true;  //if all values are found 1-9, then the whole boolean will be true
}
}
for (int i = 0 ; i<8 ; i++) {
    if (found[i] == true) {
} bool rows = true;
Console.WriteLine("bool rows true");
}

//check rows
for (int x = 0 ; x<8 ; x++)  { 
    for (int y = 0 ; y<8 ; y++) {
    int value = Sudoku[x,y];  //value equals the value in a cell in the sudkoku puzzle given an x and y value (representing row and collumn)
    found[value - 1]= true;  //if all values are found 1-9, then the whole boolean will be true
}
}
for (int i = 0 ; i<8 ; i++) {
    if (found[i] == true) {
} bool collumns = true;
Console.WriteLine("bool rows true");
}

if (collumns = true && rows = true) {
    Console.WriteLine("Sudoku is correct");
}


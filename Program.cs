// Cree un bucle que imprima todos los valores del 1 al 255

for(int i=1; i<256; i++){
    Console.WriteLine(i);
    }
// Cree un nuevo bucle que imprima todos los valores del 1 al 100 que sean divisibles por 3 o 5, pero no ambos

for(int j=1; j<101;j++){
    if (j%15!= 0){  
    
        if(j%3== 0 || j%5==0){
            Console.WriteLine(j);    
        }
    }
}

// Modifique el bucle anterior para imprimir "Fizz" para múltiplos de 3, "Buzz" para múltiplos de 5 y "FizzBuzz" 
// para números que son múltiplos de 3 y 5.
for(int k=1; k<101;k++){
    if (k%15==0){  
        Console.WriteLine(k+" FizzBuzz");
    }
    else if(k%3== 0){
            Console.WriteLine(k+" Fizz");    
        }
    else if(k%5==0){
            Console.WriteLine(k+" Buzz");    
        }
}


// (Opcional) Si usó bucles "for" para su solución, intente hacer lo mismo con los bucles " while". 
// ¡Viceversa si usaste bucles " while"!

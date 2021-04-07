# GraficosDeFunciones
Demuestra cómo generar un gráfico de una función en Winforms

La solución contiene dos proyectos:
- Expresiones es una librería que utiliza el compilador de CSharp para generar una subrutina que es capaz de evaluar una expresión del tipo "10*Math.Sin(x)/x-3" devolviendo el resultado para un valor de x dado.
- GraficosDeFunciones es un proyecto Winforms que permite introducir la expresión en pantalla y dibujar su grafico entre unos valores dados.
Al ejecutar el programa, el formulario aparece pre-populado con un ejemplo.
Se trata solo de una demostración para enseñar cómo lograr este tipo de resultado. No es un producto final debidamente "productizado" -- no tiene control de errores, ni logging, ni ayuda...
Ojo, no dispone de nada para "descargar" de memoria el ensamblado que se genera al compilar. En una aplicación real sería necesario gestionarlo para evitar la fuga de memoria cada vez que se genere un ensamblado para procesar una función nueva.

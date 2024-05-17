# FALLOS Y DECISIONES POKEMONS
*(LUCARIO, ARTICUNO y CHANDELURE no incluidos ya que son los nuestros).*

Los pokemons que no están centrados suponemos que vienen así por defecto, eso no lo editaremos. Tampoco hemos editado animaciones. En los que hemos corregido los métodos `verFilaVida` y `verFilaEnergia`, los hemos arreglado con la lógica que tenían; si ocultaban la barra de vida en vez de quitar la fila del grid, hemos añadido que se oculte la foto de la vida en vez de cambiar esta lógica, al igual con la energía. Si no tenía nada, nuestra lógica.

## 1. GengarJCC
- **verFilaVida**: La fila de la vida no se quitaba porque estaba puesto para la de la energía, editamos el código para que se quitase la fila correspondiente.
- **animacionAtaqueFuerte**: En nuestra lógica, el ataque que se realiza es fuerte hasta tener menos de una cantidad de energía. Dado que el ataque fuerte nos cierra el programa, hemos cambiado esto en el código del Gengar de forma que siempre sea el ataque débil, que sí funciona.
- **animacionHerido** y **animacionCansado**: Al igual que el ataque fuerte, no funcionan, por lo que pusimos la animación por defecto.
- **Animaciones de las pociones**: Pusimos que la opacity sea de 0 cuando es false, no de 0.5.
- **Otras notas**: La posición del Pokémon no se respeta en las animaciones y además no está siempre en la animación por defecto, por eso esto no lo hemos podido corregir.

## 2. ButterfreeACC
- **verFondo, verFilaVida, verFilaEnergia, verNombre, verPocionEnergia, verPocionVida**: No funcionaban, hemos tenido que arreglarlos. Lo arreglamos siguiendo la lógica que tenía de antes, por eso `verFilaVida` y `verFilaEnergia` no están como en ArticunoACG, por ejemplo.
- No lo pudimos meter en viewbox porque el XAML es un desastre.

## 3. LaprasACE
- No nos ha dado problemas.

## 4. MakuhitaAPQ
- Hemos arreglado el **verFondo** que no funcionaba. También hemos añadido en **verFilaVida** y **verFilaEnergia** que se oculten las imágenes de la vida y energía.
- En el XAML hemos puesto el nombre de Makuhita como textblock y no como textbox.

## 5. ScizorAPJ
- Hemos quitado los botones del XAML y hemos comentado los métodos relacionados con estos.
- Arreglo de obtener y establecer la vida y energía del Scizor.
- Hemos respetado la lógica de las animaciones de herido y cansado (aunque no vemos que esté bien debido a que, como podemos observar, no se mantiene el Pokémon cansado o herido por la lógica de los métodos de las animaciones). Además, no se respeta que esté cansado y herido, cosa que no podemos hacer porque no tenemos tiempo para editar animaciones.

## 6. SnorlaxROC
- Hemos tenido que arreglar todos los métodos relacionados con ocultar cosas (**verNombre, verFondo, verFilaVida, verFilaEnergia, verPocionVida, verPocionEnergia**).
- El método **activarAniIdle** lo hemos dejado vacío, ya que no se utiliza para nada ya que no hay animación inicial.
- Algunas animaciones se salen fuera de la pantalla, no le vemos sentido pero no podemos cambiarlo.
- El set de la energía estaba mal, lo hemos corregido.
- El ataque fuerte aparece el fondo durante un segundo, no podemos evitarlo ya que forma parte de la animación.
- Otras animaciones se salen fuera del tamaño permitido, no lo podemos editar.

## 7. GrookeyJGPMP
(AL FINAL LO HEMOS DECIDIDO QUITAR POR DEMASIADOS FALLOS DE LAS ANIMACIONES)
- No tenía implementado el **verFondo**.
- **verFilaVida** y **verFilaEnergia** estaban mal hechos.

## 8. ToxicroackJPG
- Hemos tenido que rellenar atributos y corregir algunos métodos.

## 9. CharizardASM
- Hemos corregido los atributos y hemos añadido al canvas una viewbox que lo encierra.
- Métodos **verFilaVida** y **verFilaEnergia** corregidos para que quiten también las fotos del corazón y la energía.
- Método **verFondo** corregido.
- La animación de recuperar energía no vuelve a su estado inicial, así que el Pokémon queda a partir de que le das a incrementar energía como mega evolucionado y una vez que le das de nuevo a recuperar energía, este ya no rehace la animación ya que ya está mega evolucionado.
- La animación de **noHerido** dura demasiado de tal manera que se solapa en el caso que curemos al Pokémon y lleguemos al umbral de que el Pokémon ya no esté herido.
- Hemos eliminado el método **matar** ya que no nos servía para tener todo consistente.

## 10. GarchompVFJD
- Métodos relacionados con los botones que había en la interfaz comentados, y botones quitados del XAML.
- Progress bars arregladas.
- Método **verFondo** arreglado.
- Hemos completado los métodos **verNombre, verFilaVida** y **verFilaEnergia** que no tenían nada.
- Corregidos los métodos **verPocionVida** y **verPocionEnergia**.
- La animación de derrota se ve mal, pero eso no lo podemos editar porque es por como es esta animación.
- No tiene animación de **NoHerido** y **NoCansado**, intentamos poner la del estado base pero por la lógica del Pokémon queda mal, hemos decidido dejarlos vacíos. El **estadoBase** no se respeta, eso no lo podemos editar debido a que depende de la lógica de algunos movimientos que hace que esta animación vaya mal. Tampoco se respeta que esté cansado y herido a la vez por sus animaciones.
```

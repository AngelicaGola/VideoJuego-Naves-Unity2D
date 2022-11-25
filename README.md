# VideoJuego-Naves-Unity2D
Este proyecto fue desarrollado como proyecto de grado de Ingeniera Electrónica cuyo objetivo principal es apoyar las terapias de rehabilitación de pacientes con trastornos neurológicos, mediante el uso de un videojuego y un dispositivo electrónico.

![](https://github.com/AngelicaGola/VideoJuego-Naves-Unity2D/blob/main/campo.png)

El videojuego es realizado en el programa Unity 2D; este va de la mano con el dispositivo el cual se diseñó tanto la parte electrónica como ergonómica.

El dispositivo internamente tiene integrado un Bluetooth el cual hace de control para que dentro del videojuego se ejecute la acción, en este caso se mueva la nave y dispare los misiles para acabar con su enemigo.

El videojuego consta de tres niveles diferentes: Nivel 0- aprestamiento, Nivel 1 Fuerza instantánea, Nivel 2 Fuerza Sostenida.

##Nivel 0
Aprestamiento: El paciente se familiarizará con el juego y movimiento de la nave, para esto deberá esquivar una serie de meteoritos que irán cayendo en un tiempo determinado. El paciente pasará el nivel si durante 60 segundos no choca con ninguno de ellos

##Nivel 1
Fuerza instantánea: Una vez exista control sobre la nave, el paciente empezará a aplicar fuerzas pequeñas, lo que en la vida real se traducirá en soltar y ejercer presión rápidamente sobre el dispositivo. La nave ejecutará la acción de lanzar una bomba para poder acabar con los meteoritos que aparecerán en un tiempo determinado al ejercer una fuerza. Si el usuario no logra esquivar alguno de ellos, perderá un porcentaje de la vida. Se dispondrá de un tiempo de 60 segundos, para acabar con el mayor número de meteoritos y no dejarse hacer daño de ninguno de estos. El juego terminará cuando se acabe este tiempo o se hayan perdido las tres vidas con las que se dispone.
Evaluará: Fuerza, fuerza promedio y fuerza máxima 

##Nivel 2
Fuerza Sostenida. Esta fase final se centra en medir la fuerza de agarre, donde el usuario tendrá que ejercer una fuerza mínima para activar la acción de lanzar una bomba y un tiempo mínimo (establecido por el terapeuta) en el cual tendrá que ejercer esta fuerza, si cumple con estas condiciones la nave empezará a lanzar las bombas. Así como en el nivel 1, el jugador deberá esquivar o destruir el meteorito que vayan saliendo. Se dispondrá de un tiempo de 60 segundos, para acabar con el mayor número de meteoritos y no dejarse hacer daño de ninguno de estos. El juego terminará cuando se acabe este tiempo o se hayan perdido las tres vidas con las que dispone el jugador. 
Evaluará: Fuerza, fuerza promedio y fuerza máxima.

A continuación, se muestra los diferentes movimientos generados por el videojuego 

![Movimientos generados en el juego](https://github.com/AngelicaGola/VideoJuego-Naves-Unity2D/blob/main/movimientos.png)

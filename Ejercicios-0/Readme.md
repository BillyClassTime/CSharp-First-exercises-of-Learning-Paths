### Asignacion de letras 

| Nombre                            | Letra 1 | Letra 2 |
| --------------------------------- | ------- | ------- |
| Alcaide Fernández, Inocente       | U       | X       |
| Cabrero  Luengo, Miguel Ángel     | D       | N       |
| Casais  Recondo, Carola           | G       | F       |
| Castillo  Villarino, José Carlos  | I       | R       |
| De  Vega Ampudia, Sergio          | C       | O       |
| Diaz  Fernandez, Juan Ramon       | Y       | Ñ       |
| Fuentes,  José                    | K       | W       |
| Garcia  Elez, Daniel              | J       | A       |
| Garrido  Herrador, Justo Antonio  | Q       | M       |
| Casais  Recondo, Carola           |         | H       |
| Moreno  Quevedo, Francisco Javier | V       | Z       |
| Rodríguez  Cruz, Luis Miguel      | E       | P       |
| Salvador  Román, Juan José        | S       | B       |
| Tejero  Calderera, José Vicente   | T       | L       |



### Ejemplo Letra H

|      |       |       |       |       |       |       |       |
| ---- | ----- | ----- | ----- | ----- | ----- | ----- | ----- |
|      | 0     | 1     | 2     | 3     | 4     | 5     | 6     |
| 0    | ***** |       |       |       |       |       | ***** |
| 1    | ***** |       |       |       |       |       | ***** |
| 2    | ***** |       |       |       |       |       | *     |
| 3    | ***** | ***** | ***** | ***** | ***** | ***** | ***** |
| 4    | ***** |       |       |       |       |       | ***** |
| 5    | ***** |       |       |       |       |       | ***** |
| 6    | ***** |       |       |       |       |       | ***** |

| Colum/row | Position | Asterisco |
| --------- | -------- | --------- |
| colum     | 0        | *         |
| row       | 3        | *         |
| column    | 6        | *         |

### Ejemplo Letra P

|      | 0     | 1     | 2     | 3     | 4     | 5     | 6     |
| ---- | ----- | ----- | ----- | ----- | ----- | ----- | ----- |
| 0    | ***** | ***** | ***** | ***** | ***** | ***** |       |
| 1    | ***** |       |       |       |       |       | ***** |
| 2    | ***** |       |       |       |       |       | ***** |
| 3    | ***** | ***** | ***** | ***** | ***** | ***** |       |
| 4    | ***** |       |       |       |       |       |       |
| 5    | ***** |       |       |       |       |       |       |
| 6    | *     |       |       |       |       |       |       |

| Colum /row | Position | Asterisco/New Condition | Condition | Asterisco |
| ---------- | -------- | ----------------------- | --------- | --------- |
| colum      | 0        | *                       |           |           |
| row        | 0        | Columa                  | <6        | *         |
| column     | 6        | row                     | 1         |           |
|            |          | row                     | 2         | *         |
| row        | 3        | column                  | <6        | *         |
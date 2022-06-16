## Итоговая проверочная работа
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []


### _**Текстовое описание алгоритма:**_

1. Задать первоначальный массив строк
2. Перебрать с помощью цикла все элементы этого массива
3. Сравнить количество символов каждого элемента с заданным значением n, количество символов должно быть <= n.  
*по условию задачи, n=3*
4. Если условие (3) выполняется, сохраняем полученный элемент в новый массив строк (count-счетчик элементов нового массива), и переходим к шагу (2)
5. При невыполнении условия (3) переходим к шагу (2)
6. Выходим из цикла после перебора всех элементов первоначально заданного массива
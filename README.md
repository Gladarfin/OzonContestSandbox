<h3>Задания:</h3>

<details>
  <summary>A. Сумматор (5 баллов)</summary>

<h2><p>A. Сумматор (5 баллов)</p></h2>

- ограничение по времени на тест: *3 секунды*
- ограничение по памяти на тест: *256 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*

Эта задача познакомит вас с тестирующей системой Codeforces.
Правильные решения задач должны проходить все заранее заготовленные тесты жюри и укладываться в ограничения по времени/памяти на каждом тесте.
Ниже перечислены технические требования к решениям:

- решение располагается в одном файле исходного кода;
- решение читает входные данные со стандартного ввода (экрана);
- решение пишет выходные данные на стандартный вывод (экран);
- решение не взаимодействует как-либо с другими ресурсами компьтера (сеть, жесткий диск, процессы и прочее);
- решение использует только стандартную библиотеку языка;
- решение располагается в пакете по-умолчанию (или его аналоге для вашего языка), имеют стандартную точку входа для консольных программ;

гарантируется, что во всех тестах выполняются все ограничения, что содержатся в условии задачи — как-либо проверять входные данные на корректность не надо, все тесты строго соответствуют описанному в задаче формату;
выводи ответ в точности в том формате, как написано в условии задачи (не надо выводить «поясняющих» комментариев типа введите число или ответ равен);
решения можно отправлять сколько угодно раз (пожалуйста, только без абьюза системы).
Для вашего удобства тесты, на которых будут тестироваться ваши решения, являются открытыми. В каждой задаче можно скачать архив тестов (смотрите сайдбар справа, раздел «Материалы соревнования»).

## Перейдём к задаче.

Напишите программу, которая выводит сумму двух целых чисел.

Так как это ознакомительная задача, то вы можете посмотреть и отправить авторские примеры решений (смотрите ссылку в сайдбаре в разделе «Материалы соревнования»). Конечно, в других задачах примеры решений не предоставляются.

### Входные данные
В первой строке входных данных содержится целое число **t** (1 ≤ t ≤ 10^4) — количество наборов входных данных в тесте.

Далее следуют описания **t** наборов входных данных, один набор в строке.

В первой (и единственной) строке набора записаны два целых числа **a** и **b** (−1000 ≤ a, b ≤ 1000).

### Выходные данные
Для каждого набора входных данных выведите сумму двух заданных чисел, то есть  **a + b**.
</details>

<details>
<summary>B. Сумма к оплате (10 баллов)</summary>
  
<h2><p>B. Сумма к оплате (10 баллов)</p></h2>

- ограничение по времени на тест: *1 секунда*
- ограничение по памяти на тест: *256 мегабайт*
- ввод: *стандартный ввод*
- вывод:  *стандартный вывод*
***
В магазине акция: «купи три одинаковых товара и заплати только за два». Конечно, каждый купленный товар может участвовать лишь в одной акции. Акцию можно использовать многократно.

Например, если будут куплены 7 товаров одного вида по цене 2 за штуку и 5 товаров другого вида по цене 3 за штуку, то вместо 7 * 2 + 5 * 3 надо будет оплатить 5 * 2 + 4 * 3 = 22.

Считая, что одинаковые цены имеют только одинаковые товары, найдите сумму к оплате.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

В первой строке записано целое число **t** (1 ≤ t ≤ 10**4) — количество наборов входных данных.

Далее записаны наборы входных данных. Каждый начинается строкой, которая содержит **n** (1 ≤ n ≤ 2 * 10^5) — количество купленных товаров. Следующая строка содержит их цены *p1,p2,…,pn* (1 ≤ pi ≤ 10^4). Если цены двух товаров одинаковые, то надо считать, что это один и тот товар.

Гарантируется, что сумма значений **n** по всем тестам не превосходит 2 * 10^5.

### Выходные данные

Выведите **t** целых чисел — суммы к оплате для каждого из наборов входных данных.
</details>


<details>
<summary>C. Парное программирование (10 баллов)</summary>

<h2><p>C. Парное программирование (10 баллов)</p></h2>
  
- ограничение по времени на тест: *1 секунда*
- ограничение по памяти на тест: *512 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
В компании работает **n** разработчиков, где **n** — четное число. Сумасшедший менеджер решил разбить всех разработчиков на команды по два человека.

Для этого он составил список всех разработчиков и назначил каждому из них номер по списку (от 1 до **n**)
и значение **ai** — уровень мастерства **i**-го в списке разработчика.

Очередную команду он составляет следующим образом:

первый разработчик в команде тот, кто идет первым в списке;
ему в пару подбирается такой, что разница их уровней минимальна (то есть минимально значение *|ai−aj|*, где **|x|** — это модуль числа **x/*);
если таких кандидатов несколько, то выбирается из них тот, кто находится раньше в списке;
эти два разработчика образуют команду и удаляются из списка.
Например, если массив a равен *[2,1,3,1,1,4]*, то формирование команд будет происходить следующим образом:

назначим разработчикам номера *[1,2,3,4,5,6]* в соответствии с их положением в списке, первый среди них имеет номер **1**,
его уровень мастерства *a1=2*, подходящими (с минимальной абсолютной разностью) являются разработчики с номерами *2,3,4,5*,
первый среди них **2**, таким образом первая команда — это разработчики с номерами **1** и **2/*;
оставшиеся разработчики теперь имеют номера *[3,4,5,6]*, первый среди них **3**, его уровень *a3=3*,
разработчик с минимальной абсолютной разностью только один (номер **6**), таким образом команда — разработчики с номерами **3** и **6**;
оставшиеся разработчики имеют номера *[4,5]*, первый среди них **4**, его уровень *a4=1*,
остался только разработчик с номером **5**, таким образом третья команда — разработчики с номерами **4** и **5**.
Ваша задача — помочь сумасшедшему менеджеру промоделировать процесс разбиения на команды. Обратите внимание,
что команды должны быть выведены в порядке, описанном выше в условии.

### Входные данные
Первая строка содержит одно целое число **t** (1 ≤ t ≤ 50) — количество наборов входных данных.

Первая строка каждого набора содержит одно целое число **n** (2 ≤ n ≤ 50; **n** четное) — количество разработчиков.

Вторая строка содержит *n* целых чисел *a1,a2,…,an* (1 ≤ ai ≤ 100), где **ai** — уровень мастерства *i*-го разработчика.

### Выходные данные
Для каждого набора входных данных выведите n2 строк, **i**-я строка должна содержать пару чисел — номер
первого и второго разработчика в **i**-й команде в порядке, описанном в условии.

Выводите пустую строку между выводами для наборов входных данных.
</details>

<details>
<summary>D. Электронная таблица (10 баллов)</summary>


<h2><p>D. Электронная таблица (10 баллов)</p></h2>
  
- ограничение по времени на тест: *1 секунда*
- ограничение по памяти на тест: *256 мегабайт*
- ввод: **стандартный ввод**
- вывод: **стандартный вывод**
***
Вам необходимо написать часть функциональности обработки сортировок в электронных таблицах.

Задана прямоугольная таблица **n × m** (**n** строк по **m** столбцов) из целых чисел.

Если кликнуть по заголовку **i**-го столбца, то строки таблицы пересортируются таким образом, что в этом столбце значения будут идти по неубыванию (то есть возрастанию или равенству). При этом, если у двух строк одинаковое значение в этом столбце, то относительный порядок строк не изменится.

## Рассмотрим пример.

В этом примере сначала клик был совершен по второму столбцу, затем по первому и, наконец, по третьему.

Заметим, что если кликнуть подряд два раза в один столбец, то после второго клика таблица не изменится (в момент второго клика она уже отсортирована по этому столбцу).

Обработайте последовательность кликов и выведите состояние таблицы после всех кликов.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

В первой строке записано целое число **t** (1 ≤ t ≤ 100) — количество наборов входных данных в файле. Далее следуют описания наборов, перед каждым из них записана пустая строка.

В первой строке набора записаны два целых числа **n** и **m** (1 ≤ n, m ≤ 30) — количество строк и столбцов в таблице.

Далее следуют **n** строк по **m** целых чисел в каждой — начальное состояние таблицы. Все элементы таблицы от 1 до 100.

Затем входные данные содержат строку с один целым числом **k** (1 ≤ k ≤ 30) — количество кликов.

Следующая строка содержит **k** целых чисел *c1,c2,…,ck* (1 ≤ ci ≤ m) — номера столбцов, по которым были осуществлены клики. Клики даны в порядке их совершения.

### Выходные данные

Для каждого набора входных данных выведите **n** строк по **m** чисел в каждой — итоговое состояние таблицы. После каждого набора выходных данных выводите дополнительный перевод строки.
</details>

<details>
<summary>E. Отчет (15 баллов)</summary>

<h2><p>E. Отчет (15 баллов)</p></h2>
  
- ограничение по времени на тест: *2 секунды*
- ограничение по памяти на тест: *512 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
Директор IT-корпорации оценивает эффективность работы сотрудников по различным показателям и критериям. Один из этих критериев сформулирован следующим образом: приступив к некоторому заданию, сотрудник должен завершить его, не переключаясь на другие задания.

Чтобы проверить сотрудников на соответствие этому критерию, директор потребовал от каждого сотрудника отчет о том, какие задания он выполнял в последние **n** дней. Отчет — это последовательность из **n** целых чисел *a1,a2,…,an*, где **ai** — идентификатор задания, которое сотрудник выполнял в **i**-й день.

Вам необходимо написать программу, проверяющую, соответствует ли сотрудник критерию по его отчету. Сотрудник соответствует этому критерию, если не существует такого задания x, которое выполнялось с перерывом (т. е. в некоторый день **i** сотрудник выполнял задание **x**, в дни с **i + 1** по **j − 1** он занимался другими заданиями, а в день **j** сотрудник продолжил выполнение задания **x**, при этом **j > i + 1**). Иными словами, каждое задание, которое выполнял сотрудник, должно занимать один непрерывный отрезок дней.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

В первой строке задано одно целое число **t** (1 ≤ t ≤ 10) — количество наборов входных данных.

Каждый набор входных данных состоит из двух строк. В первой строке задано одно целое число **n** (3 ≤ n ≤ 50000). Во второй строке заданы n целых чисел *a1,a2,…,an* (1 ≤ ai ≤ n) — отчет сотрудника.

### Выходные данные

Для каждого набора входных данных выведите ответ на отдельной строке. Если отчет соответствует критерию, выведите **YES**, иначе выведите **NO**.
</details>

<details>
<summary>F. Отрезки времени (20 баллов)</summary>

<h2><p>F. Отрезки времени (20 баллов)</p></h2>

- ограничение по времени на тест: *2 секунды*
- ограничение по памяти на тест: *512 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
Вам задан набор отрезков времени. Каждый отрезок задан в формате HH:MM:SS-HH:MM:SS, то есть сначала заданы часы, минуты и секунды левой границы отрезка, а затем часы, минуты и секунды правой границы.

Вам необходимо выполнить валидацию заданного набора отрезков времени. Иными словами, вам нужно проверить следующие условия:

часы, минуты и секунды заданы корректно (то есть часы находятся в промежутке от 0 до 23, а минуты и секунды — в промежутке от 0 до 59);
левая граница отрезка находится не позже его правой границы (но границы могут быть равны);
никакая пара отрезков не пересекается (даже в граничных моментах времени).
Вам необходимо вывести **YES**, если заданный набор отрезков времени проходит валидацию, и **NO** в противном случае.

Вам необходимо ответить на **t** независимых наборов тестовых данных.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

Первая строка входных данных содержит одно целое число **t** (1 ≤ t ≤ 10) — количество наборов тестовых данных. Затем следуют **t** наборов.

Первая строка набора содержит одно целое число **n** (1 ≤ n ≤ 2 * 10 ^ 4) — количество отрезков времени. В следующих **n** строках следуют описания отрезков.

Описание отрезка времени задано в формате HH:MM:SS-HH:MM:SS, где HH, MM и SS — последовательности из двух цифр. Заметьте, что никаких пробелов в описании формата нет. Также ни в одном описании нет пробелов в начале и конце строки.

### Выходные данные

Для каждого набора тестовых данных выведите ответ — **YES**, если заданный набор отрезков времени проходит валидацию, и **NO** в противном случае. Ответы выводите в порядке следования наборов во входных данных.
</details>


<details>
<summary>G. Возможные друзья (20 баллов)</summary>

<h2><p>G. Возможные друзья (20 баллов)</p></h2>
  
- ограничение по времени на тест: *3 секунды*
- ограничение по памяти на тест: *512 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
Во многих социальных сетях у пользователей есть возможность указать других пользователей как своих друзей. Помимо этого, часто существует система рекомендации друзей, которая показывает пользователям людей, с которыми они знакомы косвенно (через кого-то из своих друзей), и предлагает добавить этих людей в список друзей. Вам предстоит разработать систему рекомендации друзей.

В интересующей нас социальной сети n пользователей, каждому из которых присвоен уникальный **id** от **1** до **n**. У каждого пользователя этой сети не более **5** друзей. Очевидно, ни один пользователь не является другом самому себе, и если пользователь **x** в списке друзей **у** пользователя **y**, то и пользователь **y** входит в список друзей пользователя **x**.

Опишем, как должен формироваться список возможных друзей для каждого пользователя. Для пользователя **x** в список должны входить такие пользователи **y**, что:

**y** не является другом **x** и не совпадает с **x**;
у пользователя **y** и у пользователя **x** есть хотя бы один общий друг;
не существует такого пользователя **y***, который удовлетворяет первым двум ограничениям, и у которого строго больше общих друзей с **x**, чем у **y** с **x**.
Иными словами, в список возможных друзей пользователя **x** входят все такие пользователи, не являющиеся его друзьями, для которых количество общих друзей с **x** максимально. Обратите внимание, что список возможных друзей может быть пустым.

Вы должны написать программу, которая по заданной структуре социальной сети формирует списки возможных друзей для всех пользователей сети.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

В первой строке заданы два целых числа **n** и **m** (2 ≤ n ≤ 50000; 0 ≤ m ≤ min(n(n − 1) / 2, 5n / 2)) — количество пользователей и количество пар друзей, соответственно.

Далее следуют m строк, в каждой из которых заданы два целых числа **xi** и **yi** (1 ≤ xi,yi ≤ n; xi ≠ yi) — очередная пара друзей в социальной сети. Каждая пара друзей задается не более одного раза; у каждого пользователя не более **5** друзей.

### Выходные данные

Для каждого пользователя от **1** до **n** выведите в отдельной строке список его возможных друзей в следующем формате:

если список возможных друзей пуст, выведите одно целое число **0**;
иначе выведите **i**d возможных друзей пользователя в возрастающем порядке.
</details>
<details>
<summary>H. Валидация карты (25 баллов)</summary>

<h2><p>H. Валидация карты (25 баллов)</p></h2>
  
- ограничение по времени на тест: *1 секунда*
- ограничение по памяти на тест: *512 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
В этой задаче вам необходимо реализовать валидацию корректности карты для стратегической компьютерной игры.

Карта состоит из гексагонов (шестиугольников), каждый из которых принадлежит какому-то региону карты. В файлах игры карта представлена как n строк по m символов в каждой (строки и символы в них нумеруются с единицы). Каждый нечетный символ каждой четной строки и каждый четный символ каждой нечетной строки — точка (символ . с ASCII кодом 46); все остальные символы соответствуют гексагонам и являются заглавными буквами латинского алфавита. Буква указывает на то, какому региону принадлежит гексагон.

Посмотрите на картинку ниже, чтобы понять, как описание карты в файлах игры соответствует карте из шестиугольников.

Соответствие описания карты в файле (слева) и самой карты (справа). Регионы **R**, **G**, **V**, **Y** и **B** окрашены в красный, зеленый, фиолетовый, желтый и синий цвет, соответственно.
Вы должны проверить, что каждый регион карты является одной связной областью. Иными словами, не должно быть двух гексагонов, принадлежащих одному и тому же региону, которые не соединены другими гексагонами этого же региона.

Карта слева является корректной. Карта справа не является корректной, так как гексагоны, обозначенные цифрами 1 и 2, принадлежат одному и тому же региону (обозначенному красным цветом), но не соединены другими гексагонами этого региона.
Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

В первой строке задано одно целое число **t** (1 ≤ t ≤ 100) — количество наборов входных данных.

Первая строка набора входных данных содержит два целых числа **n** и **m** (2 ≤ n, m ≤ 20) — количество строк и количество символов в каждой строке в описании карты.

Далее следуют **n** строк по **m** символов в каждой — описание карты. Каждый нечетный символ каждой четной строки и каждый четный символ каждой нечетной строки — точка (символ . с ASCII кодом 46); все остальные символы соответствуют гексагонам и являются заглавными буквами латинского алфавита.

### Выходные данные

На каждый набор входных данных выведите ответ в отдельной строке — **YES**, если каждый регион карты представляет связную область, или **NO**, если это не так.
</details>

<details>
<summary>I. Планировщик задач (30 баллов)</summary>

<h2><p>I. Планировщик задач (30 баллов)</p></h2>
  
- ограничение по времени на тест: *3 секунды*
- ограничение по памяти на тест: *256 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
Представьте, вы собрали собственный сервер из **n** разнородных процессоров и теперь решили создать для него простейший планировщик задач.

Ваш сервер состоит из **n** процессоров. Но так как процессоры разные, то и достигают они одинаковой скорости работы при разном энергопотреблении. А именно, **i**-й процессор в нагрузке тратит **ai** энергии за одну секунду.

Вашему серверу в качестве тестовой нагрузки придет **m** задач. Про каждую задачу вам известны два значения: **tj** и **lj** — момент времени, когда задача **j** придет и время выполнения задачи в секундах.

Для начала вы решили реализовать простейший планировщик, ведущий себя следующим образом: в момент **tj** прихода задачи, вы выбираете свободный процессор с минимальным энергопотреблением и выполняете данную задачу на выбранном процессоре все заданное время. Если к моменту прихода задачи свободных процессоров нет, то вы просто отбрасываете задачу.

Процессор, на котором запущена задача **j** будет занят ровно **lj** секунд, то есть освободится ровно в момент **tj + lj** и в этот же момент уже может быть назначен для выполнения какой-то другой задачи.

Определите суммарное энергопотребление вашего сервера при обработке m заданных задач (будем считать, что процессоры в простое не потребляют энергию).

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

В первой строке заданы два целых числа **n** и **m** (1 ≤ n, m ≤ 3 * 10^5) — количество процессоров и задач соответственно.

Во второй строке заданы **n** целых чисел *a1,a2,…,an* (1 ≤ ai ≤ 10^6) — энергопотребление соответствующих процессоров под нагрузкой в секунду. Все энергопотребления различны.

В следующих **m** строках заданы описания задач: по одному в строке. В **j**-й строке заданы два целых числа **tj** и **lj** (1 ≤ tj ≤ 10^9;  1 ≤ lj ≤ 10^6) — момент прихода **j**-й задачи и время ее выполнения.

Все времена прихода **tj** различны, и задачи заданы в порядке времени прихода.

### Выходные данные

Выведите единственное число — суммарное энергопотребление сервера, если потреблением энергии в простое можно пренебречь.
</details>

<details>
<summary>J. Рифмы (30 баллов)</summary>

<h2><p>J. Рифмы (30 баллов)</p></h2>
  
- ограничение по времени на тест: *2 секунды*
- ограничение по памяти на тест: *512 мегабайт*
- ввод: *стандартный ввод*
- вывод: *стандартный вывод*
***
Вы разрабатываете программу автоматической генерации стихотворений. Один из модулей этой программы должен подбирать рифмы к словам из некоторого словаря.

Словарь содержит **n** различных слов. Словами будем называть последовательности из *1—10* строчных букв латинского алфавита.

Зарифмованность двух слов — это длина их наибольшего общего суффикса (суффиксом будем называть какое-то количество букв в конце слова). Например:

task и flask имеют зарифмованность 3 (наибольший общий суффикс — ask);
decide и code имеют зарифмованность 2 (наибольший общий суффикс — de);
id и void имеют зарифмованность 2 (наибольший общий суффикс — id);
code и forces имеют зарифмованность 0.
Ваша программа должна обработать **q** запросов следующего вида: дано слово **ti** (возможно, принадлежащее словарю), необходимо найти слово из словаря, которое не совпадает с **ti** и имеет максимальную зарифмованность с **ti** среди всех слов словаря, не совпадающих с **ti**. Если подходящих слов несколько — выведите любое из них.

Неполные решения этой задачи (например, недостаточно эффективные) могут быть оценены частичным баллом.

### Входные данные

Первая строка содержит одно целое число **n** (2 ≤ n ≤ 50000) — размер словаря.

Далее следуют **n** строк, **i**-я строка содержит одну строку **si** (1 ≤ |si| ≤ 10) — **i**-е слово из словаря. В словаре все слова различны.

Следующая строка содержит одно целое число **q** (1 ≤ q ≤ 50000) — количество запросов.

Далее следуют **q** строк, **i**-я строка содержит одну строку **ti** (1 ≤ |ti| ≤ 10) — **i**-й запрос.

Каждая строка **si** и каждая строка **ti** состоит только из строчных букв латинского алфавита.

### Выходные данные

Для каждого запроса выведите одну строку — слово из словаря, которое не совпадает с заданным в запросе и имеет с ним максимальную зарифмованность (если таких несколько — выведите любое).
</details>

<details>
<summary>K. Пользователи и заказы (SQL, 10 баллов)</summary>

<h2><p>K. Пользователи и заказы (SQL, 10 баллов)</p></h2>
  
- ограничение по времени на тест: *15 секунд*
- ограничение по памяти на тест: *1024 мегабайта*
- ввод: *стандартный ввод*
- вывод" *стандартный вывод*
- ***
Это необычная задача — вам надо написать SQL-запрос.
В качестве решения вы должны отослать один запрос к базе данных, который возвращает требуемые данные.
При проверке вашего решения используется PostgreSQL 15.1.
В качестве входных данных вам предоставляется дамп состояния базы данных. Обратите внимание,
что время работы вашего решения на тесте включает восстановление состояния базы данных из дампа,
но это время значительно меньше ограничения по времени.
Вы можете использовать сервис http://sqlfiddle.com/ как инструмент для запуска запросов.

Напишите запрос к базе данных, который возвращает всех пользователей, сделавших хотя бы один заказ.
Выведите всех таких пользователей, отсортировав их по имени (при равенстве по id).

Схема базы данных содержит две таблицы: users и orders, которые связаны отношением «один ко многим».
Изучите входные данные примера, чтобы подробно ознакомиться со схемой базы данных.
Диаграмма ниже иллюстрирует схему базы данных.

### Входные данные

Входными данными в этой задаче является дамп базы данных.
Вам он может быть полезен для ознакомления с состоянием базы данных для конкретного теста.
В качестве решения вы должны отправить один SQL-запрос.

### Выходные данные

Ваш SQL-запрос должен вывести всех пользователей в порядке неубывания их имён (по возрастанию id при равенстве имён).
Используйте collation по умолчанию.
</details>

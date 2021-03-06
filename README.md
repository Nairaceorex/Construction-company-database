# Construction company database

## Требования к заданию:
Таблицы, запросы и фильтры должны полностью соответствовать заданию.

Каждая таблица должна содержать как минимум, заданное в квадратных скобках число записей.

Информация, вводимая в таблицы должна содержать осмысленную информацию, соответствующую заданию.

Типы данных полей таблиц должны соответствовать хранимой в них информации.

В первичных таблицах поля связи должны иметь тип данных "Счётчик", а во вторичных таблицах - тип данных "Числовой".

Для каждой таблицы, должна быть создана ленточная форма.

На всех формах для таблиц необходимо отобразить все поля, кроме полей связи в первичных таблицах (поля, имеющие тип данных "Счётчик"), а поля связи во вторичных таблицах отобразить при помощи "Выпадающих списков" или "Простых списков" (таким образом, вместо кодов связи должны отображаться значения из первичных таблиц, соответствующие этим кодам).

На всех формах для таблиц необходимо разместить кнопки перемещения по записям, добавления и удаления записей, кнопку открытия табличной формы, кнопку закрытия формы и кнопки, отображающие отчёт с той же информацией что и на форме.

Для каждой таблицы, запроса и фильтра должны быть созданы табличная форма и отчёт.

В верхней части каждой формы, отчёта и страницы, должна быть надпись-заголовок с именем таблицы, запроса или фильтра.

На табличных формах должна быть реализована сортировка данных по выбранному полю, поиск информации и фильтрация по заданному полю.

На всех табличных формах для запросов и фильтров необходимо отобразить все поля, кроме полей связи.

На всех табличных формах необходимо разместить кнопки перемещения по записям, кнопку поиска информации, кнопку закрытия формы и кнопки, отображающие отчёт и страницу с той же информацией что и на форме.

Во все отчёты поместить все поля из таблиц запросов и фильтров, кроме полей связи.

Поля отдельных записей в отчётах выделить цветом и рамкой.

Для запроса "Отдел кадров" создать форму с гистограммой заработной платы сотрудников.

На форму, отображающую этот "Отдел кадров" поместить кнопки для открытия формы и страницы с гистограммами.

Создать главную кнопочную форму.

В верхнюю часть главной кнопочной формы поместить надпись с названием БД.

В центре разместить вкладки "Формы" и "Отчёты".

На соответствующие вкладки поместить кнопки для открытия всех форм и отчётов. На кнопках или рядом с ними должны быть поясняющие надписи.

Создать форму "О программе".

Создать форму "Заставка".

В нижней части главной кнопочной формы разместить кнопки для выхода из программы, открытия формы о программе и формы с гистограммой.

Сделать форму "Заставка" стартовой.

## Задание №19: БД Строительной компании.

### Таблицы:
Сотрудники (Код сотрудника, ФИО, Возраст, Пол, Адрес, Телефон, Паспортные данные, Код должности)[10 записей].

Должности (Код должности, Наименование должности, Оклад, Обязанности, Требования)[5 записей].

Виды работ (Код вида, Наименование, Описание, Цена работы, Код материала 1, Код материала 2, Код материала 3)[5 записей].

Материалы (Код материала, Наименование, Упаковка, Описание, Цена) [5 записей].

Бригады (Код бригады, Код сотрудника 1, Код сотрудника 2, Код сотрудника 3) [5 записей].

Заказчики (Код заказчика, ФИО, Адрес, Телефон, Паспортные данные)[5 записей].

Заказы (Код заказчика, Код вида работ, Код бригады, Стоимость, Дата начала, Дата окончания, Отметка о завершении, Об оплате, Код сотрудника) [10 записей].

### Запросы:	
Отдел кадров (Связывает таблицы "Сотрудники" и "Должности" по полю "Код должности").

Список работ (Связывает таблицы "Виды работ" и "Материалы" по полям "Код материала", "Код материала 1", "Код материала 2" и "Код материала 3").

Список бригад (Связывает таблицы "Бригады" и "Сотрудники" по полям "Код сотрудника", "Код сотрудника 1", "Код сотрудника 2" и "Код сотрудника 3").

Список заказов (Связывает таблицы "Заказы", "Виды работ", "Бригады" и "Сотрудники" по полям "Код вида", "Код бригады" и "Код сотрудника").

### Фильтры:	
Фильтры для отображения сотрудников отдельных должностей (На основе запроса "Отдел кадров").

Фильтры для отображения отдельных видов работ (На основе запроса "Список работ").

Фильтры заказов на конкретные работы (На основе запроса "Список заказов").

Фильтры для отображения заказов отдельных заказчиков (На основе запроса "Список заказов").

Фильтры на заказы, выполняемые отдельными бригадами (На основе запроса "Список заказов").

Фильтры для завершённых и не завершённых заказов (На основе запроса "Список заказов").

Фильтры для оплаченных и неоплаченных заказов (На основе запроса "Список заказов").

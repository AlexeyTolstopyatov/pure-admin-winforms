## Назначения окон (форм)

В каталоге ```/forms``` содержатся все окна проекта, включая логику поведения, бизнесс-логику процессов и конструкторы.

### Parent Form
Главное окно (Рабочий стол), который собирает все дочерние окна в себя. Форма рабочего стола поддерживает
Многодокументный Интерфейс (Multi-Document Interface), для обеспечения композиции и удобства эксплуатации

```
Parent Form(
	-> Journal Form
	-> Query Form
	-> Table Form
	-> Registry Form
)
```

### О функциях окна
Внутри ```ParentForm``` существуют закрытые автоопределенные функции, для обеспечения жизни окна.
Описание и использование функций будет описано в ```ParentFormCalls.md```

### Journal Form
Окно журнала событий, произошедших за время использования системы
Вызов:
```CSharp
new JournalForm(String[]).Show();

OpenChildWindowAsync(new JournalForm(String[]));
```

### QueryForm
Окно выполнения запросов для администрирования базы данных
Вызов:
```CSharp
OpenChildWindowAsync(new QueryForm(void));
```

### TableForm
Окно представления таблицы

Вызов:
```CSharp
OpenChildWindowAsync(new TableForm(DataTable));
```

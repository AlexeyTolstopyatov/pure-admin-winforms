﻿## Вызовы внутри ParentForm

Внутри родительской формы (Рабочего стола) существуют определенные функции инициализации.
Вызовы, используемые для работы окна представлены списком ниже

 - ```OpenChildWindowAsync```
 - ```CreateMenuItemAsync```
 - ```LoadObjectsAsync```
 - ```CollectInformationAsync```

Функция открытия дочернего окна используется для передачи компонента и настройки его открытия внутри ```ParentForm```
```CSharp 
OpenChildWindowAsync(Form);
```

Функция создания элементов меню (для меню ```WindowsItems```)
Создает элемент ```ToolMenuStripItem```, настраивает его и передает в коллекцию ```WindowsItems.DropDownItems```

```CSharp
CreateMenuItemAsync(string);
```

Функция загрузки элементов меню используется для отображения всех доступных таблиц из базы данных
```CSharp
LoadObjectsAsync();
```

Функция сбора информации о системе была добавлена для просмотра сведений во время аутентификации в систему


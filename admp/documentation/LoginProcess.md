## Описание процесса Идеинтификации и Авторизации
Процесс идеинтификации - это определение личности пользователя, совершающего вход в систему.
Внутри "Pure" идеинтификация происходит на этапе входа SQL Server
Для аутентификации (идеинтификации) используется Base API и служба ```AuthenticationManager```

Статические параметры для BaseAPI описаны в ```Connection.setting```
```XML
<Setting 
    Name="ConnectingString" 
    Type="System.String" 
    Scope="User">
      
      <Value Profile="(Default)">
            SERVER=nidompc\sqlexpress;DATABASE=stroy;trusted_connection=true
      </Value>
</Setting>
```

### Использование AuthenticationManager
Внутри Pure Admin упоминание Authentication Manager встречается при инициализации окон.
```CSharp
if (AuthenticationManager.InitializePersonal() == true)
    Application.Run(parent);
else
    Connect();
```

## Использование AuthorizationManager
Если личность пользователя (согласно политике SQL Server) совпадает,
Происходит этап перенаправления пользователя на его рабочее место (процесс авторизации)
Данные личности должны быть одинаковыми внутри хранилища пользователей базы данных и таблице клиентов

Проверка наличия пользователя происходит так же с помощью BaseAPI и службы авторизации
```CSharp
await AuthorizationManager.ProvideAsync(new object[2] {login, password});
```

Если функция не поддерживает ожидание или выполнение авторизации должно происходить синхронно
Используется
```CSharp
AutorizationManager.Provide(new object[2] {login, password});
```



# Baza danych Rossmanna
Rossmann potrzebuje nowej biblioteki do zarządzania swoją bazą danych. Oto jej struktura:

1. products.json
```json
{
    "Products": 
    [
        {
            "Id": ...,
            "Name": "...",
            "Price": ...,
            "Popularity": ...
        },
        ...
    ]
}
```

2. accounts.json
```json
{
    "Accounts":
    [
        {
            "Username": "...",
            "Password": "...",
            "IsAdmin": true lub false,
            "FavouriteProducts": [ lista id produktów po przecinku ]
        },
        ...
    ]
}
```

3. discounts.json
```json
{
    "Discounts": 
    [
        {
            "Title": "...",
            "Description": "...",
            "Products": [ lista id produktów po przecinku ],
            "Value": ... (wartość obniżki w procentach)
        },
        ...
    ]
}
```

## Cel zadania

Twoim zadaniem jest zbudować bibliotekę, w postaci aplikacji konsolowej, która udostępni następujące funkcjonalności:
1. Możliwość przeglądania listy produktów, sortowania jej po cenie lub popularności oraz dodawania produktów do ulubionych (po zalogowaniu)
2. Możliwość przeglądania listy promocji
3. Możliwość utworzenia konta oraz zalogowania się do systemu
4. Możliwość dodawania nowych promocji oraz produktów do bazy danych, gdy zalogowany użytkownik jest administratorem

## Nabyte umiejętności:
1. Szlifowana nadal serializacja i deserializacja
2. Umiejętność podziału funkcjonalności na klasy i obiekty
3. Wstępne opanowanie zasad projektowania usług backendowych na prostym przykładzie
4. Opanowanie podstawowych metod z biblioteki Linq (sortowanie, przeglądanie, mapowanie itp.)

### Powodzenia mimu <3
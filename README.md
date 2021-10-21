# ATM Withdrawal

[![.NET](https://img.shields.io/static/v1?label=.Net&message=3.1&color=purple)](https://dotnet.microsoft.com)
[![License](https://img.shields.io/static/v1?label=License&message=MIT&color=blue)](LICENCE.md)

Basic ATM withdrawal console app written in .NET using OOP.

## Features

- Welcome menu.
- Select dispense mode for cash denomminations.
  - First mode: 200 and 1,000.
  - Second mode: 100 and 500.
  - Efficient mode (default): 100, 200, 500 and 1,000
- Dispense cash only for the selected mode/denominations.

## Example

- Withdraw with efficient mode.

```csharp
Enter amount to withdraw: 800

* - The ATM have dispensed:
    1 x 500
    1 x 200
    1 x 100
```

- Withdraw with first mode and invalid amount.

```csharp
Enter amount to withdraw: 150

! - Sorry only this denominations can be dispense:
    1000 - 200
! - Please enter a correct amount.
```

## License

```xml
MIT License

Copyright (c) 2021 Anibal
```

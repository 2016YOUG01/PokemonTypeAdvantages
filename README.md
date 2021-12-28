# PokemonTypeAdvantages

PokemonTypeAdvantages is a program that tells you what type is better based on the types you entered.

## Installation

Click this [link](https://drive.google.com/drive/folders/1-uBxfleuJBeAabxwH6LfYdJ3LahMcGr4?usp=sharing) or to download the installer and run 

```bash
"setup.exe" or "PokemonTypeAdvantages.exe"
```
Running "setup.exe" will install the program on your computer and to uninstall it visit [here](https://support.microsoft.com/en-us/windows/uninstall-or-remove-apps-and-programs-in-windows-10-4b55f974-2cc6-2d2b-d092-5905080eaf98) .

## Example

```bash
Input: ice
Input: dragon

Output: ice > dragon
Output: either invalid or normal damage
```
```bash
Input: ghost
Input: psychic

//Output: ghost > psychic
//Output: psychic > ghost
```

## Terms

```bash
type > type
type < type
One type is better than another.

type < type
type > type
One type is better than another.

type > type
type > type
Effective against both.

type < type
type < type
Ineffective against both.


(activeType) (</>) (encounterType)
(encounterType) (</>) (activeType)
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[License](https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab)

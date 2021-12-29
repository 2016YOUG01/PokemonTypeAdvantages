# PokemonTypeAdvantages

PokemonTypeAdvantages is a program that tells you what type is better based on the types you entered.

## Installation

Click this [link](https://drive.google.com/file/d/1Y9aQdQfyvD56ZJsatgvEA7O-R1IJhef3/view?usp=sharing) to download the installer.


```bash
cd Downloads
start setup.exe
```
or
```bash
cd Downloads
start PokemonTypeAdvantages.exe
```
IF you change your default download folder or moved the file 
```bash
cd [filename]
start setup.exe
```
or
```bash
cd [filename]
start PokemonTypeAdvantages.exe
```
For help uninstalling click [here](https://support.microsoft.com/en-us/windows/uninstall-or-remove-apps-and-programs-in-windows-10-4b55f974-2cc6-2d2b-d092-5905080eaf98) .

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

Output: ghost > psychic
Output: psychic > ghost
```
```bash
Input: normal
Input: ghost

Output: normal = ghost
Output: ghost = normal
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

type = type
type (</>/=) type
activeType deals no damage to encounterType

type (</>/=) type
type = type
encounterType deals no damage to encounterType


(activeType) (</>/=) (encounterType)
(encounterType) (</>/=) (activeType)
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[License](https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab)

# PokemonTypeAdvantages

PokemonTypeAdvantages is a software that outputs which type is better based on your input .

## Installation

Click this [link](https://drive.google.com/file/d/1r-dgzsDHdO91IWc5Yo_8-I4yqApHwKne/view?usp=sharing) to download the self-contained installer.

![](https://cdn.discordapp.com/attachments/925645428639268897/925647275844337694/2021-12-29_15_10_09-general_-_Discord.png)
![](https://cdn.discordapp.com/attachments/925645428639268897/925647276213411871/2021-12-29_15_10_25-general_-_Discord.png)
![](https://cdn.discordapp.com/attachments/925645428639268897/925647276418924585/2021-12-29_15_10_39-general_-_Discord.png)
![](https://cdn.discordapp.com/attachments/925645428639268897/925647276616060978/2021-12-29_15_11_11-general_-_Discord.png)


Need help uninstalling? Click [here](https://support.microsoft.com/en-us/windows/uninstall-or-remove-apps-and-programs-in-windows-10-4b55f974-2cc6-2d2b-d092-5905080eaf98) .

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

![](https://cdn.discordapp.com/attachments/925648458101190667/925650118433202236/2021-12-29_15_22_09-PokemonTypeAdvantages.png)
![](https://cdn.discordapp.com/attachments/925648458101190667/925650118621925387/2021-12-29_15_22_29-PokemonTypeAdvantages.png)
![](https://cdn.discordapp.com/attachments/925648458101190667/925650118798098443/2021-12-29_15_22_47-PokemonTypeAdvantages.png)

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

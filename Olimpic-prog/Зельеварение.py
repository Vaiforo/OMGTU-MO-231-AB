def prog(actions: list):
    spell_words: dict = {
        "MIX": ("MX", "XM"),
        "WATER": ("WT", "TW"),
        "DUST": ("DT", "TD"),
        "FIRE": ("FR", "RF"),
    }
    spells: list = []
    without_numbers: list = []
    final_spell: str = ""
    last_action: int = len(actions)

    for number_action, action in enumerate(actions):
        action_words: list = action.rstrip("\n").split()

        spell: str = spell_words[action_words[0]][0]
        have_number: bool = False
        for action_word in action_words[1:]:
            if action_word.isdigit():
                index: int = int(action_word)
                try:
                    del without_numbers[without_numbers.index(index - 1)]
                except:
                    pass
                have_number = True
                spell += spells[index - 1]
            else:
                spell += action_word
        spell += spell_words[action_words[0]][1]

        spells.append(spell)
        if not have_number:
            without_numbers.append(number_action)
    without_numbers.append(last_action)

    for index in without_numbers:
        final_spell += spells[index - 1]
    return final_spell

for i in range(1, 11):
    with open(f"Зельеварение\input{i}.txt", encoding="utf8") as file:
        data = file.readlines()
        answer: str = prog(data)
    with open(f"Зельеварение\output{i}.txt", encoding="utf8") as file:
        data = file.readline()
        print(i)
        print(f"right: {data} my: {answer}")
        print(data == answer)
        print()

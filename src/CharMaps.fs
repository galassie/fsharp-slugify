namespace FSlugify

module CharMaps =

    let InternalCharMap = Map.ofArray [|
        // Acute accents
        ('á', "a"); ('Á', "A");
        ('é', "e"); ('É', "E");
        ('í', "i"); ('Í', "I");
        ('ó', "o"); ('Ó', "O");
        ('ú', "u"); ('Ú', "U");
        ('ý', "y"); ('Ý', "Y");
        // Circumflex accents
        ('â', "a"); ('Â', "A");
        ('ê', "e"); ('Ê', "E");
        ('î', "i"); ('Î', "I");
        ('ô', "o"); ('Ô', "O");
        ('û', "u"); ('Û', "U");
        // Umlaut/Dieresis accents
        ('ä', "a"); ('Ä', "A");
        ('ë', "e"); ('Ë', "E");
        ('ï', "i"); ('Ï', "I");
        ('ö', "o"); ('Ö', "O");
        ('ü', "u"); ('Ü', "U");
        // Grave accents
        ('à', "a"); ('À', "A");
        ('è', "e"); ('È', "E");
        ('ì', "i"); ('Ì', "I");
        ('ò', "o"); ('Ò', "O");
        ('ù', "u"); ('Ù', "U");
        // Tilde accents
        ('ã', "a"); ('Ã', "A");
        ('ñ', "n"); ('Ñ', "N");
        ('õ', "o"); ('Õ', "O");
        // Cedilla accent
        ('ç', "c"); ('Ç', "C");
        // Pashto
        ('ټ', "p"); ('ځ', "z");
        ('څ', "c"); ('ډ', "d");
        ('ﺫ', "d"); ('ﺭ', "r");
        ('ړ', "r"); ('ﺯ', "z");
        ('ږ', "g"); ('ښ', "x");
        ('ګ', "g"); ('ڼ', "n");
        ('ۀ', "e"); ('ې', "e");
        ('ۍ', "ai");
        // Russian
        ('А', "A"); ('а', "a");
        ('Б', "B"); ('б', "b");
        ('В', "V"); ('в', "v");
        ('Г', "G"); ('г', "g");
        ('Д', "D"); ('д', "d");
        ('Е', "E"); ('е', "e");
        ('Ж', "Zh"); ('ж', "zh");
        ('З', "Z"); ('з', "z");
        ('И', "I"); ('и', "i");
        ('Й', "J"); ('й', "j");
        ('К', "K"); ('к', "k");
        ('Л', "L"); ('л', "l");
        ('М', "M"); ('м', "m");
        ('Н', "N"); ('н', "n");
        ('О', "O"); ('о', "o");
        ('П', "P"); ('п', "p");
        ('Р', "R"); ('р', "r");
        ('С', "S"); ('с', "s");
        ('Т', "T"); ('т', "t");
        ('У', "U"); ('у', "u");
        ('Ф', "F"); ('ф', "f");
        ('Х', "H"); ('х', "h");
        ('Ц', "Cz"); ('ц', "cz");
        ('Ч', "Ch"); ('ч', "ch");
        ('Ш', "Sh"); ('ш', "sh");
        ('Щ', "Shh"); ('щ', "shh");
        ('Ъ', "b"); ('ъ', "b");
        ('Ы', "Y"); ('ы', "y");
        ('Ь', "b"); ('ь', "b");
        ('Э', "E"); ('э', "e");
        ('Ю', "Yu"); ('ю', "yu");
        ('Я', "Ya"); ('я', "ya");
        ('Ё', "Yo"); ('ё', "yo");
    |]
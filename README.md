readme available only in Polish (sorry!)

# C-tadela

    C-tadela to projekt zaliczeniowy z przedmiotu "Projektowanie Obiektowe".

# Czym jest cytadela?

    C-tadela to gra napisana pod silnik Unity wykorzystując język C# wraz z bibliotekami udostępnionymi przez Unity oraz Mono. Jest luźno inspirowana grą karciano-planszową "Cytadela" autorstwa Bruno Faidutti'ego.

# Logika gry

    W odróżnieniu od oryginału, gra będzie jednoosobowa, gdzie gracz będzie miał za zadanie wybudowanie miasta i podniesienie poziomu prestiżu do maksimum. Gra zakończy się w momencie osiągnięcia górnego limitu punktów prestiżu. Będzie ona korzystała z mechaniki tur i punktów akcji.
        - Każda tura rozpoczyna się przywróceniem stanu licznika punktów akcji do maksimum, dodaniem wartości złota dla miasta oraz wylosowaniem pary kart i przełożenie ich do ręki gracza.
        - Karty podzielą się na 2 kategorie:
            1. Karta dzielnicy - umożliwia wybudowanie dzielnicy w mieście korzystając ze złota, zwiększając liczbę punktów prestiżu miasta.
            2. Karta akcji - umożliwia wykonanie specjalnej akcji w ramach zużycia punktów akcji z puli.
        - Każda karta będzie zużywała określoną liczbę punktów zasobu (dla karty dzielnicy - złoto, dla karty akcji - punktów akcji).
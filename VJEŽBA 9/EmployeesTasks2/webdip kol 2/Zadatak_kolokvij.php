<?php

class evidencijaDolazaka {

    const POZDRAV = "Dobrodošli na vjezbu za kolokvij!";

    private $opis;

    function upisDolaska($ime, $prezime, $predmet) {

        $imePrezime[] = $ime . " " . $prezime;
        $this->opis = array($predmet => $imePrezime);

        $_SESSION[$predmet] = $imePrezime;

        foreach ($imePrezime as $value) {
            echo "Sesija: " . $_SESSION[$predmet] = $value . "\n";
        }
    }

    function ispis() {
        foreach ($this->opis as $key => $value) {
            foreach ($value as $value) {
                echo $key . "\t=>\t" . $value . "\n";
            }
        }
    }

}

$kl = new evidencijaDolazaka;
$greska = "";

if (isset($_GET["salji"])) {
    if (isset($_GET["ime"]) && isset($_GET["prezime"]) && $_GET["predmet"]) {


        $pozdrav = evidencijaDolazaka::POZDRAV;
        echo $pozdrav . "\n";

        $ime = $_GET["ime"];
        $prezime = $_GET["prezime"];
        $predmet = $_GET["predmet"];

        $kl->upisDolaska($ime, $prezime, $predmet);
        $ispis = $kl->ispis();
    } else {
        $greska = "Niste unijeli sve podatke!";
    }
}
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8"/>
        <title>Vjezba PHP</title>
    </head>
    <body>
        <br>
        <?php echo $greska; ?>
        <br>
        <form method="GET" action= "<?php echo $_SERVER["PHP_SELF"]; ?>">
            <label for="ime">Ime: </label>
            <input type="text" id="ime" name="ime" >
            <br>
            <label for="prezime">Prezime: </label>
            <input type="text" id="prezime" name="prezime" >
            <br>
            <label for="predmet">Predmet: </label>
            <input type="text" id="predmet" name="predmet" >
            <br>
            <input type="submit" name="salji" value="Posalji podatke">
        </form>
    </body>
</html>
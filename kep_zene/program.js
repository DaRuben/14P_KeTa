const KontenerDiv = document.getElementById("kulsoDiv");

for (let i = 11; i < 20; i++) {
    const BelsoDiv = document.createElement('div');
    BelsoDiv.classList.add('belso');

    const ZeneLJ = document.createElement('audio');
    ZeneLJ.classList.add('lejatszo');
    ZeneLJ.controls = false;

    const kepURL = `pictures/${i}.png`;
    const zeneURL = `music/${i}.mp3`;

    BelsoDiv.style.backgroundImage = `url(${kepURL})`;
    ZeneLJ.innerHTML = `<source src="${zeneURL}" type="audio/mp3">`;

    BelsoDiv.addEventListener('click', () => {
        stopZene();
        ZeneLJ.play();
    })

    BelsoDiv.appendChild(ZeneLJ);
    KontenerDiv.appendChild(BelsoDiv);
}

function stopZene(){
    const ZeneLejatszok = document.querySelectorAll('.lejatszo');
    ZeneLejatszok.forEach(player => player.pause());
}

const oraDiv = document.createElement('div');
oraDiv.classList.add('mutatok')
oraDiv.setAttribute('id', 'oraId')

const percDiv = document.createElement('div');
percDiv.classList.add('mutatok')
percDiv.setAttribute('id', 'percId')

const mpercDiv = document.createElement('div');
mpercDiv.classList.add('mutatok')
mpercDiv.setAttribute('id', 'mpercId')

const kozep = document.createElement('div');
kozep.setAttribute('id', 'kozep')


analogOraDiv.appendChild(oraDiv);
analogOraDiv.appendChild(percDiv);
analogOraDiv.appendChild(mpercDiv);
analogOraDiv.appendChild(kozep);


setInterval(() => {
    datum = new Date();
    const mperc = (datum.getSeconds()/60)*360;
    const perc = (datum.getMinutes()/60)*360;
    const ora = (datum.getHours()/12)*360 ;
    
    oraId.style.transform = `rotate(${ora}deg)`;
    percId.style.transform = `rotate(${perc}deg)`;
    mpercId.style.transform = `rotate(${mperc}deg)`;
    
},1000);

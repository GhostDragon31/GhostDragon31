import { namesOne, namesTwo } from "./names.js";

const initApp = () => {
    document.getElementById("submitForm").addEventListener("submit", (event) => {
        event.preventDefault();
        clearSuggestions(); //clear out segguestions
        const namesArray = generateNames(); //generate names
        console.log(namesArray);
        displayNames(namesArray);//display names
    });
}

document.addEventListener("DOMContentLoaded", initApp);

const clearSuggestions = () => {
    const display = document.getElementById("suggestionSection");
    if(!display.classList.contains("hidden")) display.classList.toggle("hidden");
    const list = document.querySelector('.suggestionSection ol');
    list.innerHTML = "";
}

const generateNames = () => {
    const randomNumberArray = [];
    for (let i = 0; i < 8;)
    {
        const randomNumber = Math.floor(Math.random() * 10); //generates random number form 0 to 9
        if (randomNumberArray.includes(randomNumber)) continue;
        randomNumberArray.push(randomNumber);
        i++;
    }
    console.log(randomNumberArray);
    const suggestion1 = namesOne[randomNumberArray[0]] + namesTwo[randomNumberArray[3]]
    const suggestion2 = namesOne[randomNumberArray[1]] + namesTwo[randomNumberArray[0]]
    const suggestion3 = namesOne[randomNumberArray[2]] + namesTwo[randomNumberArray[2]]
    const suggestion4 = namesOne[randomNumberArray[3]] + namesTwo[randomNumberArray[1]]
    const suggestion5 = namesOne[randomNumberArray[4]] + namesTwo[randomNumberArray[8]]
    const suggestion6 = namesOne[randomNumberArray[5]] + namesTwo[randomNumberArray[6]]
    const suggestion7 = namesOne[randomNumberArray[6]] + namesTwo[randomNumberArray[4]]
    const suggestion8 = namesOne[randomNumberArray[7]] + namesTwo[randomNumberArray[5]]
    
    return[suggestion1, suggestion2, suggestion3, suggestion4, suggestion5, suggestion6, suggestion7, suggestion8];
}

const displayNames = (namesArray) => {
    const list = document.querySelector('.suggestionSection ol');
    namesArray.forEach(name => {
        list.innerHTML += `<li>
            <a href="https://${name}.com/" target ="_blank">${name}</a></li>`;
    });
    const display = document.getElementById("suggestionSection");
    if(display.classList.contains("hidden")) display.classList.toggle("hidden");
}

const sanitiseInput = (inputValue) => {
    const div = document.createElement('div');
    div.textContent = inputValue;
    return div.innerHTML;
}
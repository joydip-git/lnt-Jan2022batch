//the DOM objects and the DOM APIs are all part of the browser. these source codes are wriiten in majorly C++
//when in JS code you use them, browser supplies the definition of those DOM objects, DOM APIs etc. to the JS engine

function changeContent() {
    //getElementById: Returns a reference to the first object with the specified value of the ID attribute.
    var paraObjectRef = document.getElementById('introPara')

    //updating the text content inside the paragraph dynamically
    paraObjectRef.innerText = 'Browser represents the structure of the entire HTML document/file along with the window where irt is being displayed in the browser, through a series of objects interlinked with each other (As parent-child or as sibling etc.), which is known as Document Object model (DOM).'

    //creating a new element/tag
    var newPara = document.createElement('p')
    newPara.setAttribute('style', 'background-color:green;color:white')
    //newPara.style.background = 'green'
    //newPara.style.color = 'white'
    newPara.innerText = 'The DOM is created so that from our code (JS/TS), we can manipulate the elements of the HTML document. Such as adding new elements dynamically, modifying existing elements dynamically etc.'

    var divObjectRef = document.getElementById('detailsDiv')
    divObjectRef.appendChild(newPara);
}
//changeContent();
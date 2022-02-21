//document object represents the HTML document to which this JS file is linked
var btnClickObj = document.getElementById('btnClick')
//btnClickObj.addEventListener('click', clickMe);
btnClickObj.onclick = clickMe

function clickMe() {
    btnClickObj.textContent = "Wow...You clicked Me";
    window.alert('button clicked')
}
function clickMeFirst() {
    window.alert('button first clicked')

    //create a paragraph element
    var pElement = document.createElement('p')
    pElement.setAttribute('id', 'p1');
    pElement.innerText = 'Joydip'

    var divObject = document.getElementById('nameDiv')
    divObject.appendChild(pElement)
    // var allScriptTags = document.getElementsByName('script')
    // var scriptTag = allScriptTags[0]
    // window.alert(scriptTag)
}


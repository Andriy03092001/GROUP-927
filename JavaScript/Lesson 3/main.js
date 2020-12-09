document.getElementById("btnAdd").onclick = function() {
    AddUser();
}

document.getElementById("btnDeleteItems").onclick = function() {
    DeleteSelectItems();
}

document.getElementById("btnDeleteAll").onclick = function() {
    DeleteAll();
}

document.getElementById("btnSelectAll").onclick = function() {
    SelectAll();
}



function AddUser() {
    var name = document.getElementById("txtName").value;
    var email = document.getElementById("txtEmail").value;

    document.getElementById("Rows").innerHTML += `
        <tr>
            <td> 
                <input type='checkbox' />
            </td>
            <td> ${name}</td>
            <td> ${email}</td>
        </tr>
    `;

    document.getElementById("txtName").value = "";
    document.getElementById("txtEmail").value = "";
}

function DeleteSelectItems() 
{
    var arrayTRs = document.getElementsByTagName("tr");

    for(var i = 1; i < arrayTRs.length; i++) {
        if(arrayTRs[i].getElementsByTagName('input')[0].checked) {
            arrayTRs[i].remove();
            i = 0;
        }
    }
}

function DeleteAll() 
{
    var arrayTRs = document.getElementsByTagName("tr");

    for(var i = 1; i < arrayTRs.length; i++) {
            arrayTRs[i].remove();
            i = 0;
    }
    //2:
    // document.getElementById("Rows").innerHTML = "";
}

function SelectAll() 
{
    var arrayTRs = document.getElementsByTagName("tr");
    for(var i = 1; i < arrayTRs.length; i++) {
        arrayTR[i].getElementsByTagName("input")[0].checked = true;
    }
}
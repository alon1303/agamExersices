const taskValue = document.getElementById("task").value;
const submitButton = document.getElementById("submitButton");
const form = document.getElementById("form");
console.log(taskValue);
form.addEventListener('submit', (e) =>{
    
    e.preventDefault();
    const taskValue = document.getElementById("task").value;
    if(!taskValue)
    {
        alert("please add a task");
        return;
    }
    // the field that surrounds the inputs
    const taskField = document.createElement("div");
    // the checkbox next to the task
    const taskCheckBox = document.createElement("input");
    taskCheckBox.type = 'checkbox';
    // the input of the task itself, its read only text
    const task = document.createElement("input");
    task.setAttribute('readonly','readonly');
    task.type = 'text';
    task.value = taskValue;
    // i added the check box and the task to the taskfield
    taskField.appendChild(taskCheckBox);
    taskField.appendChild(task);
    // created delete button that deletes the task
    const deleteButton = document.createElement('button');
    
    deleteButton.innerHTML = "Delete";    

    taskField.appendChild(deleteButton);

    deleteButton.addEventListener('click', (e) =>{
        taskField.remove();
    })
    
    const editButton = document.createElement('button');

    editButton.innerHTML = "Edit";

    taskField.appendChild(editButton);

    editButton.addEventListener('click', (e)=>{
        
        editButton.style.visibility = 'hidden';
        const editTask = document.createElement('input');
        editTask.type = 'text';
        editTask.readOnly = false;
        console.log("dasddsaadsadsdas");
        task.replaceWith(editTask);

        const saveButton = document.createElement('button');
        saveButton.innerHTML = "Save"
        taskField.appendChild(saveButton);

        const cancelButton = document.createElement('button');
        cancelButton.innerHTML = "Cancel";
        taskField.appendChild(cancelButton);

        saveButton.addEventListener('click',(e)=>{
            editTask.readOnly = true;
            saveButton.remove();
            cancelButton.remove();
            editButton.style.visibility = 'visible';
        })

        cancelButton.addEventListener('click', (e)=>{
            saveButton.remove();
            cancelButton.remove();
            editTask.replaceWith(task);
            editButton.style.visibility = 'visible';
        })
    })
   
    // i added the task field to a div in the html file
    const taskList = document.getElementById("tasksList");
    taskList.appendChild(taskField);

})

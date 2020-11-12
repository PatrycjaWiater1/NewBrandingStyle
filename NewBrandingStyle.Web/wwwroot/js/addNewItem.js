document.addEventListener("DOMContentLoaded", () => {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    formElement.addEventListener("submit", (event) => addnewItem(event))

    const addnewItem = async (e) => {
        e.preventDefault();
        const nameValue = document.getElementById("Name").value;
        const descriptionValue = document.getElementById("Description").value;
        const isVisibleValue = document.getElementById("IsVisible").checked;

        const companyModel = {
            Name: nameValue,
            Description: descriptionValue,
            IsVisible: isVisibleValue
        };

        const response = await fetch('/api/CompanyNew/AddNewItem', {
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(companyModel)
        });

        if (response.ok) {
            alertElement.style.display = "block";
            setTimeout(() => {
                alertElement.style.display = "none";
            }, 5000);

        }
    }
})
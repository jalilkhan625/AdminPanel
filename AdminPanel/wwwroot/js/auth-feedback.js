// wwwroot/js/auth-feedback.js

document.addEventListener("DOMContentLoaded", function () {
    const successMessage = document.getElementById("registration-success");
    const loginErrorMessage = document.getElementById("login-error");

    if (successMessage) {
        showToast(successMessage.innerText, "success");
    }

    if (loginErrorMessage) {
        showToast(loginErrorMessage.innerText, "error");
    }
});

function showToast(message, type) {
    const toast = document.createElement("div");
    toast.classList.add("custom-toast", type === "success" ? "toast-success" : "toast-error");
    toast.textContent = message;

    document.body.appendChild(toast);

    setTimeout(() => {
        toast.classList.add("show");
    }, 100); // Fade-in

    setTimeout(() => {
        toast.classList.remove("show");
        setTimeout(() => toast.remove(), 300); // Fade-out cleanup
    }, 3000);
}

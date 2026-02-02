document.getElementById("btnStartCancellationToken").onclick = async (e) => {
    const button = e.currentTarget;
    setLoading(button, true);

    try {
        const response = await fetch("/Home/Start", {
            method: "POST"
        });

        const result = await response.json();
        console.log(result);
    }
    finally {
        setLoading(button, false);
    }
};



document.getElementById("btnStartNoCancellation").onclick = async (e) => {
    const button = e.currentTarget;
    setLoading(button, true);

    try {
        const response = await fetch("/Home/StartNoCancellation", {
            method: "POST"
        });

        const result = await response.json();
        console.log(result);
    }
    finally {
        setLoading(button, false);
    }
};



function setLoading(button, isLoading) {
    const text = button.querySelector(".btn-text");
    const spinner = button.querySelector(".spinner-border");

    button.disabled = isLoading;

    if (isLoading) {
        text.classList.add("d-none");
        spinner.classList.remove("d-none");
    } else {
        text.classList.remove("d-none");
        spinner.classList.add("d-none");
    }
}

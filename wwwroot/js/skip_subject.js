function skip_subject() {
    if (document.getElementById("skip").checked) {
        document.getElementById("finalGrade").disabled = true;
        document.getElementById("interest1").disabled = true;
        document.getElementById("interest2").disabled = true;
        document.getElementById("interest3").disabled = true;
        document.getElementById("interest4").disabled = true;
        document.getElementById("interest5").disabled = true;
    } else {
        document.getElementById("finalGrade").disabled = false;
        document.getElementById("interest1").disabled = false;
        document.getElementById("interest2").disabled = false;
        document.getElementById("interest3").disabled = false;
        document.getElementById("interest4").disabled = false;
        document.getElementById("interest5").disabled = false;
    }
    
}
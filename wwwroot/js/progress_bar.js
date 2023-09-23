function check_value(item_id) {

    var progress = document.getElementById(item_id).value;

    if (progress < 50) {
        document.getElementById(item_id).classList.add("progress-red");
    } else if (progress < 80) {
        document.getElementById(item_id).classList.add("progress-yellow");
    } else {
        document.getElementById(item_id).classList.add("progress-purple");
    } 
}
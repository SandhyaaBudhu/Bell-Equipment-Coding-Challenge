const prompt = require('prompt-sync')({ sigint: true }); // prompt-sync imported to get user input from console

// user input with validation
let totalSteps;
while (true) {
    totalSteps = parseInt(prompt("Enter total number of steps in the assembly process : "));
    if (isNaN(totalSteps) || totalSteps <= 0) {
        console.log("Input Invalid. Please enter a positive number.");
    } else {
        break;
    }
}

let currentStep;
while (true) {
    currentStep = parseInt(prompt("Enter the current step number : "));
    if (isNaN(currentStep) || currentStep < 0) {
        console.log("Input Invalid. Please enter a positive number.");
    } else if (currentStep > totalSteps) {
        console.log(`Current step cannot be greater than total steps (${totalSteps}).`);
    } else {
        break;
    }
}

let currentBay;
while (true) {
    currentBay = parseInt(prompt("Enter the current bay number - Bay:"));
    if (isNaN(currentBay) || currentBay <= 0) {
        console.log("Input Invalid. Please enter a positive number.");
    } else {
        break;
    }
}


// calculations:
const remainingSteps = totalSteps - currentStep; // steps remaining

const progressPercent = ((currentStep / totalSteps) * 100).toFixed(0); // percentage - rounded to the nearest %


// output
if (currentStep === totalSteps) {
    console.log("Machine completed assembly — ready for next bay ✅");
} else {
    console.log(`\nMachine currently in Bay ${currentBay}`);
    console.log(`Steps completed : ${currentStep} of ${totalSteps}`);
    console.log(`Remaining steps : ${remainingSteps}`);
    console.log(`Progress : ${progressPercent}%`);
}

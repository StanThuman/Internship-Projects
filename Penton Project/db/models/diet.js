var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var dietPlanSchema = new Schema({
  user_id:{ type: Schema.ObjectId, ref:'Profile'},
  totalCalories: Number,
  date: String,
  food: [{
    foodName: String,
    foodType: String,
    calories: Number
  }]
});

var DietPlan = mongoose.model('dietplan', dietPlanSchema);
module.exports = DietPlan;

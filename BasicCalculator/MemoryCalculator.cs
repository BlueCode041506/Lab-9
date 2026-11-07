using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public class MemoryCalculator : Calculator
    {
        private double memoryValue = 0;
        private bool hasMemory = false;

        public void method_memoryClear() {
            memoryValue = 0;
            hasMemory = false;
        }//mem clear logic
        public void method_memoryStore(double value) {
            memoryValue = value;
            hasMemory = true;
        }//mem store logic
        public double method_memoryRecall(){
            return memoryValue;
        }//mem recall logic
        public void method_memoryAdd(double value) {
            memoryValue = (memoryValue + value);
            hasMemory = true;
        }//mem add logic
        public bool method_hasMemory() {
            return hasMemory;
        }//mem check logic
    }
}

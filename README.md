# Multilabel Annotation Tool

##  Project Overview

The **Multilabel Annotation Tool** is a desktop-based application developed using the **.NET Framework** and **C#** in **Microsoft Visual Studio**. The tool is specifically designed to facilitate efficient and accurate annotation of vehicle images for training deep learning models in vehicle analytics.

It enables users to perform **multi-attribute labeling**, including vehicle detection, classification, and number plate recognition, thereby supporting the development of intelligent transportation systems.

---

##  Objectives

* To reduce manual effort in dataset annotation
* To support multi-label classification for vehicle analytics
* To generate structured annotation data compatible with machine learning pipelines
* To improve annotation efficiency and consistency

---

##  Core Functionalities

### 1. Image Selection

Users can load vehicle images from their local system using the **Open File** option. The selected image is displayed within the application interface for annotation.

---

### 2. Spatial Annotation

* Users draw bounding boxes using the mouse
* Two primary regions are annotated:

  * Vehicle
  * Number Plate

---

### 3. Automatic Coordinate Extraction

Once bounding boxes are drawn, the system automatically calculates and records:

* X-coordinate
* Y-coordinate
* Width
* Height

This eliminates manual coordinate entry and reduces human error.

---

### 4. Multilabel Tagging

The tool supports multi-attribute labeling, allowing users to assign:

* **Vehicle Type** (e.g., Car, Truck, Bus)
* **Manufacturer Model**
* **Vehicle Color**
* **Number Plate Value** 

---

## 📤 Data Output & Integration

### Output Format

All annotations are exported in **JSON format**, ensuring structured and machine-readable data.

### Training Pipeline Integration

* Each image is paired with its corresponding JSON annotation file
* These labeled datasets are used as input for training deep learning models
* Supports object detection and classification tasks

---

##  System Architecture

The system follows a modular design:

* **User Interface Layer** → Handles image display and user interaction
* **Annotation Module** → Manages bounding box creation and labeling
* **Data Processing Module** → Extracts coordinates and metadata
* **Export Module** → Generates JSON output

---

##  Technical Environment

* **Programming Language:** C#
* **Framework:** .NET Framework
* **IDE:** Microsoft Visual Studio 
* **Architecture Support:**

  * Debug Mode
  * Release Mode
  * Any CPU Configuration

---

## 🚀 Key Features

* Custom-built annotation system tailored for vehicle datasets
* Supports **multi-label classification in a single interface**
* Automated bounding box coordinate extraction
* JSON-based export for seamless ML integration
* User-friendly and efficient workflow

---

## 📊 Contribution to Research

This tool significantly improves the dataset preparation process by:

* Reducing annotation time by approximately **50%**
* Supporting annotation across **multiple number plate formats**
* Enabling high-quality labeled datasets for training deep learning models
* Enhancing the accuracy of vehicle detection and recognition systems

---

## 🔮 Future Enhancements

* Integration of semi-automated annotation using AI assistance
* Support for additional annotation formats (e.g., XML)
* Cloud-based dataset management
* Batch processing capabilities

---

## 📎 Usage in Thesis

This tool is utilized in the thesis for:

* Dataset preparation
* Multi-attribute vehicle annotation
* Supporting CNN-based vehicle analytics framework

---

## 📧 Author

**Muhammad Shoaib**
PhD Researcher – Vehicle Analytics for Traffic Management and Law Enforcement

---

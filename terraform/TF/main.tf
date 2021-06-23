terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}

provider "azurerm" {
    features {}
}
variable "services" {
  default     = {
    "frontend"  = "cp1-web-frontend"
    "serviceone" ="cp1-web-numbers"
    "servicetwo"  ="cp1-web-luckystars"
    "servicethree"  ="cp1-web-merge"
  }
}

resource "azurerm_resource_group" "rg" {
    name     = "CPSFIA2.2"
    location = "uksouth"
    tags = {
      "project" = "true"
    }
}
resource "azurerm_app_service_plan" "app-service-plan" {
  name = "cp-tf-appservice"
  resource_group_name = azurerm_resource_group.rg.name
  location = azurerm_resource_group.rg.location
  kind = "Windows"
  reserved = false
  sku {
    tier = "Free"
    size = "F1"
  }
}
resource "azurerm_app_service" "webapp" {
  
    for_each = var.services
    name = each.value
    resource_group_name = azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.app-service-plan.id
}
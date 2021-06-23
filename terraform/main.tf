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
    "frontend"  = "cp-web-frontend"
    "serviceone" ="cp-web-letters"
    "servicetwo"  ="cp-web-luckystars"
    "servicethree"  ="cp-web-merge"
  }
}

resource "azurerm_resource_group" "rg" {
    name     = "CPSFIA2.1"
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
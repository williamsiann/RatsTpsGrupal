// Fill out your copyright notice in the Description page of Project Settings.


#include "ItemHealth.h"
#include <TpGrupalProgCharacter.h>

void AItemHealth::NotifyActorBeginOverlap(AActor* OtherActor)
{
	Super::NotifyActorBeginOverlap(OtherActor);
	if (OtherActor->Implements<UCollectHealthItem>()) {
		ICollectHealthItem::Execute_AddItemHealth(OtherActor, HealthPoints);
	}
	Destroy();
}
